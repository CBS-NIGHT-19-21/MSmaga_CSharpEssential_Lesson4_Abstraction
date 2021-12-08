class TXTReader : IDataReader
{// Implementation of methods of Interface IDataReader.
    public string GetData(IDataCluster cluster)
    {
        return "GetData from TXT";
    }
    public double ConvertData()
    {
        return 19.0;
    }
}

