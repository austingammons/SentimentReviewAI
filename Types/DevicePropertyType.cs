namespace myMLApp.Types
{
    public enum DevicePropertyType
    {
        EI, //EmotiBit Info Json
        DC, //Data Clipping, TypeTag in Payload
        DO, //Data Overflow, TypeTag in Payload
        BP, //Battery Percentage Remaining
        BV, //Battery Voltage
        DP, //SD card percent capacity filled
        RD, //Request Data, TypeTag in Payload
        PI, //Ping
        PO, //Pong
        RS, //Reset
    }
}
