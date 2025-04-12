using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace tpmodul8_103022300046
{
    //membuat class untuk membaca dan menulis file konfigurasi
    internal class CovidConfig
    {
        public Config config;

        public const String filePath = "covid_config.json";

        //membuat method untuk membaca dan menulis file baru jika belum ada
        public CovidConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        //membuat method untuk membaca file konfigurasi
        private Config ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(configJsonData);
            return config;
        }

        private void SetDefault()
        {
            config = new Config
            {
                satuan_suhu = "celcius",
                batas_hari_demam = 14,
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
            };
        }

        //membuat method untuk menulis file konfigurasi
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }

        //membuat method untuk mengubah satuan
        public void UbahSatuan()
        {
            if (this.config.satuan_suhu == "celcius")
            {
                this.config.satuan_suhu = "fahrenheit";
            }
            else
            {
                this.config.satuan_suhu = "celcius";
            }
            WriteNewConfigFile();
        }
    }
}
