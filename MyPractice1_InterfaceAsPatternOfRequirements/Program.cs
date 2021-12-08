// Use methods of implemented Interface IDataCluster
// with object of Cluster class.
Cluster cluster = new Cluster();

cluster.ReadCluster();


// Use methods of implemented Interface IDataReader
// with object of TXTReader class.
TXTReader txtReader = new TXTReader();

Console.WriteLine(txtReader.GetData(cluster));
Console.WriteLine(txtReader.ConvertData());

// Use methods of implemented Interface IDataReader
// with object of CSVReader class.
CSVReader csvReader = new CSVReader();

Console.WriteLine(csvReader.GetData(cluster));
Console.WriteLine(csvReader.ConvertData());

// Delay.
Console.ReadLine();