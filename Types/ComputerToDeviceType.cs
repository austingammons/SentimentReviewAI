namespace myMLApp.Types
{
    public enum ComputerToDeviceType
    {
        GL, //[GPS latitude and Longitude] [GPS]
        GS, //[GPS Speed] [GPS]
        GB, //[GPS Bearing] [GPS]
        GA, //[GPS Altitude] [GPS]
        TL, //Local Computer Timestamp
        TU, //UTC Timestamp
        TX, //Crosstime, used for timestamp comparison
        LM, //LSL Marker/message
        RB, //Record begin (Include timestamp in Data)
        RE, //Record End
        UN, //User Note
        MH, //Mode Hibernate
        HE, //Establish communication
    }
}
