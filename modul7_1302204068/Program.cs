using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302204068
{
    class program
    {
        static void Main(string[] args)
        {

        }
    }

    public class BankTransferConfig
    {
        public string lang { get; set; }
        public transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public confirmation confirmation { get; set; }
        public BankTransferConfig(string lang, transfer transfer, List<string> methods, confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
    private void WriteNewConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        String jsonString = JsonSerializer.Serialize(conf, options);
        string fullfilepath = path + "/" + fileconfigName;
        File.WriteAllText(fullfilepath, jsonString);

    }
    private void setDefault()
    {
        en = "Please insert the amount of money to transfer:";
        id = "“Masukkan jumlah uang yang akan di-transfe";
    }

    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public transfer(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }


    public class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
