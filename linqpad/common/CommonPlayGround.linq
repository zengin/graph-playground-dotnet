<Query Kind="Statements">
  <Namespace>Microsoft.Graph</Namespace>
  <Namespace>System.Net.Http.Headers</Namespace>
</Query>

//#load "init/BetaInit"
#load "init/V1Init"

var messages = client
    .Me
    .Messages
    .Request()
    .Select(m => m.Sender)
    .Top(1)
    .GetAsync()
    .Result;

foreach (var message in messages)
{
    Console.WriteLine(message);
}