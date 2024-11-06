using System.Net;
using System.Net.Sockets;

string ntpServer = "0.ch.pool.ntp.org";
byte[] ntpData = new byte[48];
ntpData[0] = 0x1B;
IPEndPoint ntpEndPoint = new IPEndPoint(Dns.GetHostAddresses(ntpServer)[0], 123);

UdpClient ntpClient = new UdpClient();
ntpClient.Connect(ntpEndPoint);
ntpClient.Send(ntpData, ntpData.Length);
ntpData = ntpClient.Receive(ref ntpEndPoint);

DateTime ntpTime = NtpPacket.ToDateTime(ntpData);
ntpTime = NtpPacket.currentDifferenceDateHour(ntp);
Console.WriteLine("Heure actuelle : " + ntpTime.ToString());
ntpClient.Close();
public class NtpPacket
{
    public static DateTime ToDateTime(byte[] ntpData)
    {
        ulong intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
        ulong fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

        var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
        var networkDateTime = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);
        return networkDateTime;
    }
    public static DateTime currentDifferenceDateHour(DateTime time)
    {

        TimeSpan timespan = DateTime.Now - time;
        return time.Add(timespan);
    }
}
