﻿string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmployeeEmail(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmployeeEmail(external[i, 0], external[i, 1], externalDomain);
}

void DisplayEmployeeEmail (string employeeFirstName, string employeeLastName, string domain = "contoso.com")
{
    Console.WriteLine($"{employeeFirstName.Substring(0,2).ToLower()}{employeeLastName.ToLower()}@{domain}");
}