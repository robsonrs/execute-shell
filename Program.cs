System.Diagnostics.Process process = new System.Diagnostics.Process();
System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
startInfo.FileName = "powershell.exe";
startInfo.Arguments = "cd $env:userprofile/Desktop; mkdir TestFolder";
startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
process.StartInfo = startInfo;
process.Start();