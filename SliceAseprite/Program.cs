using System.Diagnostics;

Directory.SetCurrentDirectory("V:\\_projects\\sbox\\terry_llc\\Assets\\aseprite");

var dir = Directory.GetCurrentDirectory();

var projects = Directory.GetFiles(dir, "*.aseprite");
string selected = string.Empty;
if (projects.Length == 0)
{
    Console.WriteLine($"No projects found in {dir}");
    return;
}

for (int i = 0; i < projects.Length; i++)
{
    var projectName = Path.GetFileNameWithoutExtension(projects[i]);
    var info = new ProcessStartInfo($"aseprite", $"-b {projects[i]} --save-as ./{projectName}/{{slice}}.png");
    var p = Process.Start(info);
}