// See https://aka.ms/new-console-template for more information
using Packt.Shared;
using Tx = Texas;
using Env = System.Environment;

ConfigureConsole();

Person bob = new();

WriteLine(bob);

WriteLine(Env.OSVersion);
