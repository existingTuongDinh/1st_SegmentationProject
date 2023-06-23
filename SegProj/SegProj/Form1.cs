using System.Drawing;
using System.Windows.Forms;

namespace SegProj
{
    public partial class Form1 : Form
    {
        //load hinh goc 
        Bitmap HinhGoc = new Bitmap("C:\\Users\\84923\\Pictures\\640px-thumbnail.jpg");



        public Form1()
        {
            InitializeComponent();

            //hien thi len PicBox
            pictureBox1.Image = HinhGoc;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi thuộc tính SizeMode cho pictureBox1
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //lay du lieu va chuyen du lieu string thanh du lieu so de thuat toan co the hieu
            int x1 = Convert.ToInt16(textBoxX1.Text); // co 4 toa do de tao ra cai vung , 2 toa do chi la duong thang
            int x2 = Convert.ToInt16(txtboxX2.Text);
            int y1 = Convert.ToInt16(txtboxY1.Text);
            int y2 = Convert.ToInt16(txtboxY2.Text);
            int Nguong = Convert.ToInt16(txtboxThreshold.Text);
            

            //khai bao bien so thuc , bat dau = 0 de tinh gia tri cua red light , green light va blue light
            double aRtb = 0, aGtb = 0, aBtb = 0;

            //tinh vecto mau trung binh ( average vector color )
            for (int x = x1; x <= x2; x++) // duyet qua cac pixel thuoc vung anh da chon
                for (int y = y1; y <= y2; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    aRtb += pixel.R; //vecto a= [aR aG aB] , chua ba thanh phan trung binh mau cho tung kenh R G B
                    aGtb += pixel.G; // lay mau cho tung kenh
                    aBtb += pixel.B;
                }

            //double size ((x2-x1+1)*(y2-y1+1))
            //tai moi kenh mau R,G,B tinh trung binh cong
            double Size = Math.Abs((x2 - x1) * (y2 - y1)); // tinh tong so luong pixel trong vung anh da chon
            aRtb /= Size;
            aGtb /= Size;
            aBtb /= Size;

            //phan doan anh
            //tao mot anh bitmap chua hinh segmentation
            Bitmap SegImg = new Bitmap(HinhGoc.Width, HinhGoc.Height); //Bitmap la mot lop trong thu vien System.Drawing de luu tru anh duoi dang pixel
            //vecto z la diem anh tai vi tri x,y ma chung ta muon tinh xem no thuoc nen ( back ground ) hay thuoc doi tuong (object)
            for (int x = 0; x < HinhGoc.Width; x++) //vong lap nay duyet qua tat ca cac pixel trong anh HinhGoc
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color Pixel2 = HinhGoc.GetPixel(x, y); //doi tuong color dung de dai dien cho mau trong tung pixel cua HinhGoc
                    double zR = Pixel2.R;
                    double zG = Pixel2.G;   // cac thanh phan mau R,G,B duoc lay ra va luu tru vao cac bien duoc khoi tao
                    double zB = Pixel2.B;

                    //ap dung cong thuc 6.7-1 de tinh Euclidean Distance giua 2 vecto a va z se nhu sau : 
                    double D = Math.Sqrt(Math.Pow(zR - aRtb, 2) + Math.Pow(zG - aGtb, 2) + Math.Pow(zB - aBtb, 2)); // de tinh su khac nhau giua R,G,B cua phan vung va hinh goc

                    //sau khi tinh duoc D(a,z) , ta se so sanh voi gia tri nguong (threshold) 
                    //D0 de xac dinh xem diem z(x,y) dang xet la background hay object
                    if (Convert.ToInt32(D) >= Nguong) //la background , set cho mau cac diem nay ve mau trang , //khi D la double muon chuyen ve int phai convert.to.int32
                        SegImg.SetPixel(x, y, Color.FromArgb((int)zR, (int)zG, (int)zB));
                    else //nguoc lai z(x,y) la object thi giu nguyen mau
                        SegImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    //cong thuc tren chu yeu de xac dinh do tuong dong gia tri anh sang mau giua phan vung va gia tri trung binh cua pixel mau , de xac dinh thuoc ve background hay object , tu do xu li phan loai anh
                }
            //hien thi anh da segmentation
            pictureBox2.Image = SegImg;
        }

        
    }
}
