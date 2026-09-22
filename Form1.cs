using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Point _startPoint;
        private Pen _pen;
        private Graphics _graphics;
        private ColorDialog _colorDialog;
        private Stack<Bitmap> _undoStack;
        private int _brushSize = 2;
        public Form1()
        {
            InitializeComponent();
            _colorDialog = new ColorDialog { Color = Color.Black };
            InitializeCanvas();

            comboBox1.Items.Add("2x");
            comboBox1.Items.Add("4x");
            comboBox1.Items.Add("6x");
            comboBox1.Items.Add("8x");
            comboBox1.SelectedIndex = 0;
            FormClosed += Form1_FormClosed;
        }

        private void InitializeCanvas()
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _undoStack = new Stack<Bitmap>();
            _graphics.Clear(Color.White);
            pictureBox1.Image = _bitmap;
            SetPen(Color.Black, _brushSize);

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _startPoint = e.Location;
            SaveUndoState();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_startPoint.IsEmpty)
            {
                _graphics.DrawLine(_pen, _startPoint, e.Location);
                _startPoint = e.Location;

                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _startPoint = Point.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] brushSizes = { 2, 4, 6, 8 };
            _brushSize = brushSizes[comboBox1.SelectedIndex];
            SetPen(_colorDialog.Color, _brushSize);
        }


        private void buttonRenk_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonRenk.BackColor = _colorDialog.Color;
                SetPen(_colorDialog.Color, _brushSize);

            }
        }


        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dosyaKaydet = new SaveFileDialog())
            {
                dosyaKaydet.Title = "Çizimi kaydet";
                dosyaKaydet.Filter = "PNG Dosyası|*.png|JPEG Dosyası|*.jpg|Bitmap Dosyası|*.bmp";
                dosyaKaydet.DefaultExt = "png";

                if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = dosyaKaydet.FilterIndex == 2 ? ImageFormat.Jpeg :
                        dosyaKaydet.FilterIndex == 3 ? ImageFormat.Bmp : ImageFormat.Png;
                    _bitmap.Save(dosyaKaydet.FileName, format);
                    MessageBox.Show("Çizim başarıyla kaydedildi.");
                }
            }

        }

        private void yUKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dosyaYükle = new OpenFileDialog())
            {
                dosyaYükle.Title = "Çizim aç";
                dosyaYükle.Filter = "PNG Dosyası|*.png|JPEG Dosyası|*.jpg|Bitmap Dosyası|*.bmp";

                if (dosyaYükle.ShowDialog() == DialogResult.OK)
                {
                    using (Image resim = Image.FromFile(dosyaYükle.FileName))
                    {
                        ReplaceCanvas(new Bitmap(resim));
                    }
                    ClearUndoHistory();
                }
            }

        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            SaveUndoState();
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();

        }


        private void buttonSilgi_Click(object sender, EventArgs e)
        {

            SetPen(Color.White, 8);

        }


        private void buttonGeriAl_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count > 0)
            {
                ReplaceCanvas(_undoStack.Pop());
            }
            else
            {
                MessageBox.Show("Geri alınacak bir işlem yok.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Paint Drawing App";
        }

        private void SetPen(Color color, int width)
        {
            if (_pen != null)
            {
                _pen.Dispose();
            }
            _pen = new Pen(color, width);
        }

        private void SaveUndoState()
        {
            _undoStack.Push((Bitmap)_bitmap.Clone());
        }

        private void ReplaceCanvas(Bitmap canvas)
        {
            Bitmap previousBitmap = _bitmap;
            _graphics.Dispose();
            _bitmap = canvas;
            _graphics = Graphics.FromImage(_bitmap);
            pictureBox1.Image = _bitmap;
            previousBitmap.Dispose();
        }

        private void ClearUndoHistory()
        {
            while (_undoStack.Count > 0)
            {
                _undoStack.Pop().Dispose();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearUndoHistory();
            _pen.Dispose();
            _graphics.Dispose();
            _bitmap.Dispose();
        }
    }
}

