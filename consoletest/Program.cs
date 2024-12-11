using Tyuiu.RogovAYu.Sprint6.Task7.V27.Lib;
DataService ds = new();
Console.WriteLine(ds.GetMatrix(Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V27.csv")));