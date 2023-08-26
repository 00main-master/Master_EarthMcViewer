using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;

namespace Master_EarthMcViewer
{
    public partial class Form1 : Form
    {
        private string result = "";
        private bool isTown = false;
        public Form1()
        {
            InitializeComponent();
        }
        int townX, townZ;
        private void TownInfoRequest_Click(object sender, EventArgs e)
        {
            TownLabel.Text = "Wait...";

            result = "";
            isTown = true;
            HttpClient client = new HttpClient();
            try
            {
                dynamic data = JObject.Parse(client.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://api.earthmc.net/v2/aurora/towns/{InputTownName.Text}/")).Result.Content.ReadAsStringAsync().Result);
                result += $"Town name: {data.name}     Nation: {data.nation}\nMayor: {data.mayor}     Balance: {data.stats.balance}\n";
                result += $"\nStatus:\n     Public: {data.status.isPublic}\n     Open: {data.status.isOpen}\n     Neutral: {data.status.isNeutral}\n     Capital: {data.status.isCapital}\n     Over Claimed: {data.status.isOverClaimed}\n     Ruined: {data.status.isRuined}";
                result += $"\nFlag:\n     PVP: {data.perms.flagPerms.pvp}\n     Explosion: {data.perms.flagPerms.explosion}\n     Fire:{data.perms.flagPerms.fire}\n     Mobs:{data.perms.flagPerms.mobs}";
                result += $"\nRegistered: {data.timestamps.registered}     Joined nation at: {data.timestamps.joinedNationAt}";
                result += "\nResidents:";
                foreach (var item in data.residents)
                {
                    result += $"\n     {item}";
                }

                townX = data.coordinates.spawn.x;
                townZ = data.coordinates.spawn.z;

                TownLabel.Text = result;
                MapLink.Text = $"{townX}, {townZ}";
            }
            catch (Exception)
            {
                TownLabel.Text = "ERROR";
            }

        }

        private void MapLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MapLink.LinkVisited = true;
                System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = $"https://earthmc.net/map/aurora/?worldname=earth&mapname=flat&zoom=6&x={townX}&y=64&z={townZ}", UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void ResidentInfoRequest_Click(object sender, EventArgs e)
        {
            TownLabel.Text = "Wait...";


            result = "";
            isTown = false;
            HttpClient client = new HttpClient();
            try
            {
                dynamic data = JObject.Parse(client.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://api.earthmc.net/v2/aurora/residents/{InputTownName.Text}/")).Result.Content.ReadAsStringAsync().Result);
                result += $"Name: {data.name}     Town: {data.town}     Nation:{data.nation}    Balance: {data.stats.balance}G";
                result += $"\nRegistered: {data.timestamps.registered}\nJoined town at: {data.timestamps.joinedTownAt}\nLast Online: {data.timestamps.lastOnline}";

                TownLabel.Text = result;
                MapLink.Text = "";
            }
            catch (Exception)
            {
                TownLabel.Text = "ERROR";
            }

        }

        private void NationsInfoRequest_Click(object sender, EventArgs e)
        {
            TownLabel.Text = "Wait...";


            result = "";
            isTown = true;
            HttpClient client = new HttpClient();
            try
            {
                dynamic data = JObject.Parse(client.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://api.earthmc.net/v2/aurora/nations/{InputTownName.Text}/")).Result.Content.ReadAsStringAsync().Result);
                result += $"Name: {data.name}     King: {data.king}     Capital: {data.capital}     Balance:{data.stats.balance}";
                result += $"\nRegistered: {data.timestamps.registered}";
                result += $"\nStatus:\n     Public:{data.status.isPublic}\n     Open:{data.status.isOpen}\n     Neutral:{data.status.isNeutral}";
                result += $"\nBoard: {data.board}     Registered: {data.timestamps.registered}";
                result += "\nTowns:";

                foreach (var item in data.towns)
                    result += $"\n     {item}";

                result += "\nResidents:";
                foreach (var item in data.residents)
                    result += $"\n     {item}";

                result += "\nAllies:";
                foreach (var item in data.allies)
                    result += $"\n     {item}";

                result += "\nEnemies:";
                foreach (var item in data.enemies)
                    result += $"\n     {item}";

                townX = data.spawn.x;
                townZ = data.spawn.z;

                TownLabel.Text = result;
                MapLink.Text = $"{townX}, {townZ}";
            }
            catch (Exception)
            {

                TownLabel.Text = "ERROR";
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Stream stream = saveFileDialog.OpenFile();
            if (isTown)
                stream.Write(Encoding.UTF8.GetBytes($"{result}\nPos:{townX}, {townZ}"));
            else
                stream.Write(Encoding.UTF8.GetBytes(result));
            stream.Close();
        }
    }
}