namespace Bai4
{
    class MangSoNguyen
    {
        //phuong thuc nhap mot so > 0
        public int NhapSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            return so;
        }
        //phuong thuc nhap mot so
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        //phuong thuc nhap mang
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //phuong thuc in mang
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }
        //Sinh viên xây dựng thêm các phương thức khác 
        // Em sữ dụng hàm có sẳn
        public int TimSoLonNhat(int[] a)
        {
            return a.Max();
        }
        public int TimSoNhoNhat(int[] a)
        {
            return a.Min();
        }
        public int TinhTong(int[] a)
        {
            return a.Sum();
        }
        public void SapXepTangDan(int[] a)
        {
            Array.Sort(a);
        }
    }
}

    
