﻿using System;
using System.IO;
using System.Windows.Forms;

namespace PPPOE_Connect
{
    class add_link
    {
        public static void Create_link(int version)
        {
            int fileErrorTag = 0;
            try
            {
                string name = "%userprofile%\\AppData\\Roaming\\Microsoft\\Network\\Connections\\Pbk\\rasphone.pbk";
                string path = Environment.ExpandEnvironmentVariables(name);

                //判断pbk文件是否有错误
                if (File.Exists(path))
                {
                    using (var sr = File.OpenText(path))
                    {
                        string strLine;
                        while ((strLine=sr.ReadLine())!=null)
                        {
                            if (strLine.IndexOf("PBVersion=1")!=-1)
                            {
                                fileErrorTag = 1;
                            }
                        }
                    };
                    if (fileErrorTag!=0)
                    {
                        Logging.Error("pbk文件有误");
                        File.Delete(path);
                    }
                }
                string dir = Path.GetDirectoryName(path);
                FileStream fileStream = null;
                StreamWriter streamWriter = null;
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                if (version == 8)
                {
                    fileStream = new FileStream(path, FileMode.Create);
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine("[CYJH]");
                    streamWriter.WriteLine("Encoding=1");
                    streamWriter.WriteLine("PBVersion=3");
                    streamWriter.WriteLine("Type=5");
                    streamWriter.WriteLine("AutoLogon=0");
                    streamWriter.WriteLine("UseRasCredentials=0");
                    streamWriter.WriteLine("LowDateTime=-818462512");
                    streamWriter.WriteLine("HighDateTime=30443896");
                    streamWriter.WriteLine("DialParamsUID=20892187");
                    streamWriter.WriteLine("Guid=72F5E29CB04A004FA5424259E7490741");
                    streamWriter.WriteLine("VpnStrategy=0");
                    streamWriter.WriteLine("ExcludedProtocols=0");
                    streamWriter.WriteLine("LcpExtensions=1");
                    streamWriter.WriteLine("DataEncryption=8");
                    streamWriter.WriteLine("SwCompression=0");
                    streamWriter.WriteLine("NegotiateMultilinkAlways=0");
                    streamWriter.WriteLine("SkipDoubleDialDialog=0");
                    streamWriter.WriteLine("DialMode=0");
                    streamWriter.WriteLine("OverridePref=15");
                    streamWriter.WriteLine("RedialAttempts=3");
                    streamWriter.WriteLine("RedialSeconds=60");
                    streamWriter.WriteLine("IdleDisconnectSeconds=0");
                    streamWriter.WriteLine("RedialOnLinkFailure=1");
                    streamWriter.WriteLine("CallbackMode=0");
                    streamWriter.WriteLine("CustomDialDll=");
                    streamWriter.WriteLine("CustomDialFunc=");
                    streamWriter.WriteLine("CustomRasDialDll=");
                    streamWriter.WriteLine("ForceSecureCompartment=0");
                    streamWriter.WriteLine("DisableIKENameEkuCheck=0");
                    streamWriter.WriteLine("AuthenticateServer=0");
                    streamWriter.WriteLine("ShareMsFilePrint=0");
                    streamWriter.WriteLine("BindMsNetClient=0");
                    streamWriter.WriteLine("SharedPhoneNumbers=0");
                    streamWriter.WriteLine("GlobalDeviceSettings=0");
                    streamWriter.WriteLine("PrerequisiteEntry=");
                    streamWriter.WriteLine("PrerequisitePbk=");
                    streamWriter.WriteLine("PreferredPort=PPPoE6-0");
                    streamWriter.WriteLine("PreferredDevice=WAN Miniport (PPPOE)");
                    streamWriter.WriteLine("PreferredBps=0");
                    streamWriter.WriteLine("PreferredHwFlow=0");
                    streamWriter.WriteLine("PreferredProtocol=0");
                    streamWriter.WriteLine("PreferredCompression=0");
                    streamWriter.WriteLine("PreferredSpeaker=0");
                    streamWriter.WriteLine("PreferredMdmProtocol=0");
                    streamWriter.WriteLine("PreviewUserPw=1");
                    streamWriter.WriteLine("PreviewDomain=0");
                    streamWriter.WriteLine("PreviewPhoneNumber=0");
                    streamWriter.WriteLine("ShowDialingProgress=1");
                    streamWriter.WriteLine("ShowMonitorIconInTaskBar=1");
                    streamWriter.WriteLine("CustomAuthKey=0");
                    streamWriter.WriteLine("AuthRestrictions=552");
                    streamWriter.WriteLine("IpPrioritizeRemote=1");
                    streamWriter.WriteLine("IpInterfaceMetric=0");
                    streamWriter.WriteLine("IpHeaderCompression=0");
                    streamWriter.WriteLine("IpAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDnsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDns2Address=0.0.0.0");
                    streamWriter.WriteLine("IpWinsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpWins2Address=0.0.0.0");
                    streamWriter.WriteLine("IpAssign=1");
                    streamWriter.WriteLine("IpNameAssign=1");
                    streamWriter.WriteLine("IpDnsFlags=0");
                    streamWriter.WriteLine("IpNBTFlags=0");
                    streamWriter.WriteLine("TcpWindowSize=0");
                    streamWriter.WriteLine("UseFlags=3");
                    streamWriter.WriteLine("IpSecFlags=0");
                    streamWriter.WriteLine("IpDnsSuffix=");
                    streamWriter.WriteLine("Ipv6Assign=1");
                    streamWriter.WriteLine("Ipv6Address=::");
                    streamWriter.WriteLine("Ipv6PrefixLength=0");
                    streamWriter.WriteLine("Ipv6PrioritizeRemote=1");
                    streamWriter.WriteLine("Ipv6InterfaceMetric=0");
                    streamWriter.WriteLine("Ipv6NameAssign=1");
                    streamWriter.WriteLine("Ipv6DnsAddress=::");
                    streamWriter.WriteLine("Ipv6Dns2Address=::");
                    streamWriter.WriteLine("Ipv6Prefix=0000000000000000");
                    streamWriter.WriteLine("Ipv6InterfaceId=0000000000000000");
                    streamWriter.WriteLine("DisableClassBasedDefaultRoute=0");
                    streamWriter.WriteLine("DisableMobility=0");
                    streamWriter.WriteLine("NetworkOutageTime=0");
                    streamWriter.WriteLine("ProvisionType=0");
                    streamWriter.WriteLine("PreSharedKey=");
                    streamWriter.WriteLine("CacheCredentials=0");
                    streamWriter.WriteLine("NumCustomPolicy=0");
                    streamWriter.WriteLine("NumEku=0");
                    streamWriter.WriteLine("UseMachineRootCert=0");
                    streamWriter.WriteLine("NumServers=0");
                    streamWriter.WriteLine("NumRoutes=0");
                    streamWriter.WriteLine("NumNrptRules=0");
                    streamWriter.WriteLine("AutoTiggerCapable=0");
                    streamWriter.WriteLine("NumAppIds=0");
                    streamWriter.WriteLine("NumClassicAppIds=0");
                    streamWriter.WriteLine("DisableDefaultDnsSuffixes=0");
                    streamWriter.WriteLine("NumTrustedNetworks=0");
                    streamWriter.WriteLine("NumDnsSearchSuffixes=0");
                    streamWriter.WriteLine("PowershellCreatedProfile=0");
                    streamWriter.WriteLine("ProxyFlags=0");
                    streamWriter.WriteLine("ProxySettingsModified=0");
                    streamWriter.WriteLine("ProvisioningAuthority=");
                    streamWriter.WriteLine("AuthTypeOTP=0");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("NETCOMPONENTS=");
                    streamWriter.WriteLine("ms_msclient=0");
                    streamWriter.WriteLine("ms_server=0");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("MEDIA=rastapi");
                    streamWriter.WriteLine("Port=PPPoE6-0");
                    streamWriter.WriteLine("Device=WAN Miniport (PPPOE)");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("DEVICE=PPPoE");
                    streamWriter.WriteLine("LastSelectedPhone=0");
                    streamWriter.WriteLine("PromoteAlternates=0");
                    streamWriter.WriteLine("TryNextAlternateOnFail=1");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("");


                }
                else if (version == 7)
                {
                    fileStream = new FileStream(path, FileMode.Create);
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine("[CYJH]");
                    streamWriter.WriteLine("Encoding=1");
                    streamWriter.WriteLine("PBVersion=1");
                    streamWriter.WriteLine("Type=5");
                    streamWriter.WriteLine("AutoLogon=0");
                    streamWriter.WriteLine("UseRasCredentials=0");
                    streamWriter.WriteLine("LowDateTime=995310256");
                    streamWriter.WriteLine("HighDateTime=30446239");
                    streamWriter.WriteLine("DialParamsUID=512744");
                    streamWriter.WriteLine("Guid=5839757AAA1DFA47BD3AE30D84D8C459");
                    streamWriter.WriteLine("VpnStrategy=0");
                    streamWriter.WriteLine("ExcludedProtocols=0");
                    streamWriter.WriteLine("LcpExtensions=1");
                    streamWriter.WriteLine("DataEncryption=8");
                    streamWriter.WriteLine("SwCompression=0");
                    streamWriter.WriteLine("NegotiateMultilinkAlways=0");
                    streamWriter.WriteLine("SkipDoubleDialDialog=0");
                    streamWriter.WriteLine("DialMode=0");
                    streamWriter.WriteLine("OverridePref=15");
                    streamWriter.WriteLine("RedialAttempts=3");
                    streamWriter.WriteLine("RedialSeconds=60");
                    streamWriter.WriteLine("IdleDisconnectSeconds=0");
                    streamWriter.WriteLine("RedialOnLinkFailure=1");
                    streamWriter.WriteLine("CallbackMode=0");
                    streamWriter.WriteLine("CustomDialDll=");
                    streamWriter.WriteLine("CustomDialFunc=");
                    streamWriter.WriteLine("CustomRasDialDll=");
                    streamWriter.WriteLine("ForceSecureCompartment=0");
                    streamWriter.WriteLine("DisableIKENameEkuCheck=0");
                    streamWriter.WriteLine("AuthenticateServer=0");
                    streamWriter.WriteLine("ShareMsFilePrint=0");
                    streamWriter.WriteLine("BindMsNetClient=0");
                    streamWriter.WriteLine("SharedPhoneNumbers=0");
                    streamWriter.WriteLine("GlobalDeviceSettings=0");
                    streamWriter.WriteLine("PrerequisiteEntry=");
                    streamWriter.WriteLine("PrerequisitePbk=");
                    streamWriter.WriteLine("PreferredPort=PPPoE4-0");
                    streamWriter.WriteLine("PreferredDevice=WAN Miniport (PPPOE)");
                    streamWriter.WriteLine("PreferredBps=0");
                    streamWriter.WriteLine("PreferredHwFlow=0");
                    streamWriter.WriteLine("PreferredProtocol=0");
                    streamWriter.WriteLine("PreferredCompression=0");
                    streamWriter.WriteLine("PreferredSpeaker=0");
                    streamWriter.WriteLine("PreferredMdmProtocol=0");
                    streamWriter.WriteLine("PreviewUserPw=1");
                    streamWriter.WriteLine("PreviewDomain=0");
                    streamWriter.WriteLine("PreviewPhoneNumber=0");
                    streamWriter.WriteLine("ShowDialingProgress=1");
                    streamWriter.WriteLine("ShowMonitorIconInTaskBar=1");
                    streamWriter.WriteLine("CustomAuthKey=0");
                    streamWriter.WriteLine("AuthRestrictions=552");
                    streamWriter.WriteLine("IpPrioritizeRemote=1");
                    streamWriter.WriteLine("IpInterfaceMetric=0");
                    streamWriter.WriteLine("IpHeaderCompression=0");
                    streamWriter.WriteLine("IpAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDnsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDns2Address=0.0.0.0");
                    streamWriter.WriteLine("IpWinsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpWins2Address=0.0.0.0");
                    streamWriter.WriteLine("IpAssign=1");
                    streamWriter.WriteLine("IpNameAssign=1");
                    streamWriter.WriteLine("IpDnsFlags=0");
                    streamWriter.WriteLine("IpNBTFlags=0");
                    streamWriter.WriteLine("TcpWindowSize=0");
                    streamWriter.WriteLine("UseFlags=3");
                    streamWriter.WriteLine("IpSecFlags=0");
                    streamWriter.WriteLine("IpDnsSuffix=");
                    streamWriter.WriteLine("Ipv6Assign=1");
                    streamWriter.WriteLine("Ipv6Address=::");
                    streamWriter.WriteLine("Ipv6PrefixLength=0");
                    streamWriter.WriteLine("Ipv6PrioritizeRemote=1");
                    streamWriter.WriteLine("Ipv6InterfaceMetric=0");
                    streamWriter.WriteLine("Ipv6NameAssign=1");
                    streamWriter.WriteLine("Ipv6DnsAddress=::");
                    streamWriter.WriteLine("Ipv6Dns2Address=::");
                    streamWriter.WriteLine("Ipv6Prefix=0000000000000000");
                    streamWriter.WriteLine("Ipv6InterfaceId=0000000000000000");
                    streamWriter.WriteLine("DisableClassBasedDefaultRoute=0");
                    streamWriter.WriteLine("DisableMobility=0");
                    streamWriter.WriteLine("NetworkOutageTime=0");
                    streamWriter.WriteLine("ProvisionType=0");
                    streamWriter.WriteLine("PreSharedKey=");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("NETCOMPONENTS=");
                    streamWriter.WriteLine("ms_msclient=0");
                    streamWriter.WriteLine("ms_server=0");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("MEDIA=rastapi");
                    streamWriter.WriteLine("Port=PPPoE4-0");
                    streamWriter.WriteLine("Device=WAN Miniport (PPPOE)");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("DEVICE=PPPoE");
                    streamWriter.WriteLine("LastSelectedPhone=0");
                    streamWriter.WriteLine("PromoteAlternates=0");
                    streamWriter.WriteLine("TryNextAlternateOnFail=1");

                }
                else if (version == 6)
                {
                    name = "C:\\Documents and Settings\\All Users\\Application Data\\Microsoft\\Network\\Connections\\Pbk\\rasphone.pbk";
                    path = Environment.ExpandEnvironmentVariables(name);
                    fileStream = new FileStream(path, FileMode.Create);
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine("[CYJH]");
                    streamWriter.WriteLine("Encoding=1");
                    streamWriter.WriteLine("Type=5");
                    streamWriter.WriteLine("AutoLogon=0");
                    streamWriter.WriteLine("UseRasCredentials=0");
                    streamWriter.WriteLine("DialParamsUID=1680140");
                    streamWriter.WriteLine("Guid=86DCBD44D851964F999795E524223810");
                    streamWriter.WriteLine("BaseProtocol=1");
                    streamWriter.WriteLine("VpnStrategy=0");
                    streamWriter.WriteLine("ExcludedProtocols=3");
                    streamWriter.WriteLine("LcpExtensions=1");
                    streamWriter.WriteLine("DataEncryption=8");
                    streamWriter.WriteLine("SwCompression=1");
                    streamWriter.WriteLine("NegotiateMultilinkAlways=0");
                    streamWriter.WriteLine("SkipNwcWarning=0");
                    streamWriter.WriteLine("SkipDownLevelDialog=0");
                    streamWriter.WriteLine("SkipDoubleDialDialog=0");
                    streamWriter.WriteLine("DialMode=1");
                    streamWriter.WriteLine("DialPercent=75");
                    streamWriter.WriteLine("DialSeconds=120");
                    streamWriter.WriteLine("HangUpPercent=10");
                    streamWriter.WriteLine("HangUpSeconds=120");
                    streamWriter.WriteLine("OverridePref=15");
                    streamWriter.WriteLine("RedialAttempts=3");
                    streamWriter.WriteLine("RedialSeconds=60");
                    streamWriter.WriteLine("IdleDisconnectSeconds=0");
                    streamWriter.WriteLine("RedialOnLinkFailure=1");
                    streamWriter.WriteLine("CallbackMode=0");
                    streamWriter.WriteLine("CustomDialDll=");
                    streamWriter.WriteLine("CustomDialFunc=");
                    streamWriter.WriteLine("CustomRasDialDll=");
                    streamWriter.WriteLine("AuthenticateServer=0");
                    streamWriter.WriteLine("ShareMsFilePrint=0");
                    streamWriter.WriteLine("BindMsNetClient=0");
                    streamWriter.WriteLine("SharedPhoneNumbers=0");
                    streamWriter.WriteLine("GlobalDeviceSettings=0");
                    streamWriter.WriteLine("PrerequisiteEntry=");
                    streamWriter.WriteLine("PrerequisitePbk=");
                    streamWriter.WriteLine("PreferredPort=");
                    streamWriter.WriteLine("PreferredDevice=");
                    streamWriter.WriteLine("PreferredBps=0");
                    streamWriter.WriteLine("PreferredHwFlow=0");
                    streamWriter.WriteLine("PreferredProtocol=0");
                    streamWriter.WriteLine("PreferredCompression=0");
                    streamWriter.WriteLine("PreferredSpeaker=0");
                    streamWriter.WriteLine("PreferredMdmProtocol=0");
                    streamWriter.WriteLine("PreviewUserPw=1");
                    streamWriter.WriteLine("PreviewDomain=0");
                    streamWriter.WriteLine("PreviewPhoneNumber=0");
                    streamWriter.WriteLine("ShowDialingProgress=1");
                    streamWriter.WriteLine("ShowMonitorIconInTaskBar=1");
                    streamWriter.WriteLine("CustomAuthKey=-1");
                    streamWriter.WriteLine("AuthRestrictions=632");
                    streamWriter.WriteLine("TypicalAuth=1");
                    streamWriter.WriteLine("IpPrioritizeRemote=1");
                    streamWriter.WriteLine("IpHeaderCompression=0");
                    streamWriter.WriteLine("IpAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDnsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpDns2Address=0.0.0.0");
                    streamWriter.WriteLine("IpWinsAddress=0.0.0.0");
                    streamWriter.WriteLine("IpWins2Address=0.0.0.0");
                    streamWriter.WriteLine("IpAssign=1");
                    streamWriter.WriteLine("IpNameAssign=1");
                    streamWriter.WriteLine("IpFrameSize=1006");
                    streamWriter.WriteLine("IpDnsFlags=0");
                    streamWriter.WriteLine("IpNBTFlags=0");
                    streamWriter.WriteLine("TcpWindowSize=0");
                    streamWriter.WriteLine("UseFlags=1");
                    streamWriter.WriteLine("IpSecFlags=0");
                    streamWriter.WriteLine("IpDnsSuffix=");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("NETCOMPONENTS=");
                    streamWriter.WriteLine("ms_server=0");
                    streamWriter.WriteLine("ms_msclient=0");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("MEDIA=rastapi");
                    streamWriter.WriteLine("Port=PPPoE6-0");
                    streamWriter.WriteLine("Device=WAN 微型端口 (PPPOE)");
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine("DEVICE=PPPoE");
                    streamWriter.WriteLine("PhoneNumber=");
                    streamWriter.WriteLine("AreaCode=");
                    streamWriter.WriteLine("CountryCode=1");
                    streamWriter.WriteLine("CountryID=1");
                    streamWriter.WriteLine("UseDialingRules=0");
                    streamWriter.WriteLine("Comment=");
                    streamWriter.WriteLine("LastSelectedPhone=0");
                    streamWriter.WriteLine("PromoteAlternates=0");
                    streamWriter.WriteLine("TryNextAlternateOnFail=1");
                }
                else
                {
                    Logging.Info("未知操作系统，版本号：" + version);
                }
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Logging.Error(ex);
                MessageBox.Show("写入文件失败！请尝试管理员权限运行！");
                Environment.Exit(0);
            }
        }
    }
}
