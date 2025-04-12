﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul8_103022300046
{
    //membuat class untuk menampung konfigurasi
    internal class Config
    {
        //atribut untuk deserialisasi
        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        //constructor kosong untuk deserialisasi
        public Config() { }

        public Config(string satuan_suhu, int batas_hari_demam, string pesan_ditolak, string pesan_diterima)
        {
            this.satuan_suhu = satuan_suhu;
            this.batas_hari_demam = batas_hari_demam;
            this.pesan_ditolak = pesan_ditolak;
            this.pesan_diterima = pesan_diterima;
        }
    }
}
