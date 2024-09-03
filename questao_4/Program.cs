double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;
double totalF;

totalF = sp + rj + mg + es + outros;

double percentualSP = (sp / totalF) * 100;
double percentualRJ = (rj / totalF) * 100;
double percentualMG = (mg / totalF) * 100;
double percentualES = (es / totalF) * 100;
double percentualOutros = (outros / totalF) * 100;

Console.WriteLine($"Percentual de representação de SP: {percentualSP:F2}%");
Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:F2}%");
Console.WriteLine($"Percentual de representação de MG: {percentualMG:F2}%");
Console.WriteLine($"Percentual de representação de ES: {percentualES:F2}%");
Console.WriteLine($"Percentual de representação de Outros: {percentualOutros:F2}%");

