<Query Kind="Program">
</Query>

void Main(string[] args)
{
    var app = (args?.Length>0)? args[0]: "Default-Svc";
    Console.WriteLine($"app = {app}");

    var dirPath = new FileInfo(Util.CurrentQueryPath).Directory.Parent.Parent.FullName;

    var envs = new[] {"dev", "dde", "uat", "prd"};
    var configPath = $"{dirPath}/{app}-config.json";
    var configDir = "";

    //ad parser?
    var _3la="";
    //foreach (var env in envs){
    //    var config = 
    //}

}
