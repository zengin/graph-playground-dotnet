<Query Kind="Statements">
  <NuGetReference>Microsoft.Graph</NuGetReference>
  <Namespace>Microsoft.Graph</Namespace>
  <Namespace>System.Net.Http.Headers</Namespace>
</Query>

// prerequisite: auth token is located at ~/Desktop/token.txt
var profilePath = Environment.GetEnvironmentVariable("USERPROFILE");
var tokenPath = Path.Join(profilePath, "Desktop", "token.txt");
var token = System.IO.File.ReadAllText(tokenPath);

var client = new GraphServiceClient(new DelegateAuthenticationProvider(async request =>
{
    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
}));
