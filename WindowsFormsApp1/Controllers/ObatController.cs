using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class ObatController
    {
        private readonly ObatRepository _repository = new ObatRepository();

        public void TambahObat(Obat obat) => _repository.Insert(obat);

        public void UbahObat(Obat obat) => _repository.Update(obat);

        public void HapusObat(string kodeObat) => _repository.Delete(kodeObat);

        public DataTable AmbilSemuaObat() => _repository.GetAll();
        public DataTable CariObat(string keyword)
        {
            return _repository.Search(keyword);
        }

    }
}
