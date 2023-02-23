using myMLApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myMLApp.Rates
{
    public class SampleRate
    {
        public string FunctionName { get; set; } = string.Empty;
        public IEnumerable<BiometricType> DataType { get; set; } = Enumerable.Empty<BiometricType>();
        public string SensorIC { get; set; } = string.Empty;
        public float SamplingRate { get; set; }

        public static IEnumerable<SampleRate> GetSampleRates()
        {
            return new List<SampleRate>()
            {
                new SampleRate() {
                    FunctionName = "Motion",
                    DataType = new List<BiometricType>()
                    {
                        BiometricType.AX,
                        BiometricType.AY,
                        BiometricType.AZ,
                        BiometricType.GX,
                        BiometricType.GY,
                        BiometricType.GZ,
                        BiometricType.MX,
                        BiometricType.MY,
                        BiometricType.MZ
                    },
                    SensorIC = "BMI160+BMI150",
                    SamplingRate = 25F
                },
                new SampleRate() {
                    FunctionName = "PPG",
                    DataType = new List<BiometricType>()
                    {
                        BiometricType.PI,
                        BiometricType.PG,
                        BiometricType.PR
                    },
                    SensorIC = "max30101",
                    SamplingRate = 25F
                },
                new SampleRate() {
                    FunctionName = "Temperature",
                    DataType = new List<BiometricType>()
                    {
                        BiometricType.T0,
                        BiometricType.TH
                    },
                    SensorIC = "MAX30101 / MLX90632",
                    SamplingRate = 7.5F
                },
                new SampleRate() {
                    FunctionName = "EDA",
                    DataType = new List<BiometricType>()
                    {
                        BiometricType.EA,
                        BiometricType.EL,
                        BiometricType.ER
                    },
                    SensorIC = "ADS1113",
                    SamplingRate = 15F
                },
            };
        }

    }
}
