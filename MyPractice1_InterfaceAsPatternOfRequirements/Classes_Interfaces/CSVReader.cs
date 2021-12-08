class CSVReader : IDataReader
{   // Implementation of methods of Interface IDataReader.
    public string GetData(IDataCluster cluster)
    {
        return "GetData from CSV";
    }
    public double ConvertData()
    {
        return 13.0;
    }
}

