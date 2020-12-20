using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Forms;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        private Snakee snake;
        private Timer aTimer=new Timer();
        const int si = 20;
        //private Food oldFood;
        public Game(int x,int y)
        {
            InitializeComponent();
            snake = new Snakee(x, y);
            SetTimer();
            Image ima = new Image
            {
                Height = si,
                Width = si
            };
            Loaded+=(xx,yy)=>Keyboard.Focus(grid);
            /*BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Files/Food.png", UriKind.Relative);
            bi.EndInit();
            ima.Source = bi;
            canvas.Children.Add(ima);
            Canvas.SetLeft(ima, 100);
            Canvas.SetTop(ima, 100);
            /*Rectangle rec = new Rectangle();
            SolidColorBrush brush = new SolidColorBrush(Colors.DarkSlateBlue);
            rec.Stroke = brush;
            rec.Height = 100;
            rec.Width = 100;
            canvas.Children.Add(rec);
            Canvas.SetLeft(rec, 100);
            Canvas.SetTop(rec, 100);*/
        }
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer.Interval = 150;
            aTimer.Tick += OnTimedEvent;
            aTimer.Start();
        }
        
        public async void OnTimedEvent(Object source, EventArgs e)
        {
            if (snake.getEnd() == false)
            {
                canvas.Children.Clear();
                /* if (snake.getScore() != printer.getwy())
                 {
                     printer.setwy(snake.getScore());
                     printer.printWynik();
                 }*/
                //sciana();
                Food fod = snake.getFood();
                food(fod);
                printSnake(snake.returnElements());
                //printer.clear(snake.clear());
                Snakee.move();
                labe.Content = "Wynik: "+snake.getScore();
                
            }
            else
            {

                  
                    aTimer.Stop();
                    bum(snake.returnElements());
                    bum2(snake.returnElements());
                    bum3(snake.returnElements());
                    bum4(snake.returnElements());
                    await Task.Delay(1500);
               
                aTimer.Stop();
                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new EndGamePage(snake.getScore()));
            }
        }

        public async void bum(List<Element> list)
        {
            await Task.Delay(80);
            Image ima1 = new Image
            {

            };
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/Files/bum1.png", UriKind.Relative);
            bi1.EndInit();
            ima1.Source = bi1;
            canvas.Children.Add(ima1);
            Canvas.SetLeft(ima1, (list[list.Count - 1].getPunkt().getX() - 1) * si + 5);
            Canvas.SetTop(ima1, (list[list.Count - 1].getPunkt().getY() - 1) * si);
        }
        public async void bum4(List<Element> list)
        {
            await Task.Delay(440);
            Image ima = new Image
            {

            };
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Files/bum4.png", UriKind.Relative);
            bi.EndInit();
            ima.Source = bi;
            canvas.Children.Add(ima);
            Canvas.SetLeft(ima, (list[list.Count - 1].getPunkt().getX() - 1) * si - 12);
            Canvas.SetTop(ima, (list[list.Count - 1].getPunkt().getY() - 1) * si - 10);
        }
        public async void bum3(List<Element> list)
        {
            await Task.Delay(260);
            Image ima = new Image
            {

            };
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Files/bum3.png", UriKind.Relative);
            bi.EndInit();
            ima.Source = bi;
            canvas.Children.Add(ima);
            Canvas.SetLeft(ima, (list[list.Count - 1].getPunkt().getX() - 1) * si - 7);
            Canvas.SetTop(ima, (list[list.Count - 1].getPunkt().getY() - 1) * si - 7);
        }
        public async void bum2(List<Element> list)
        {
            await Task.Delay(260);
            Image ima = new Image
            {

            };
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Files/bum2.png", UriKind.Relative);
            bi.EndInit();
            ima.Source = bi;
            canvas.Children.Add(ima);
            Canvas.SetLeft(ima, (list[list.Count - 1].getPunkt().getX() - 1) * si - 4);
            Canvas.SetTop(ima, (list[list.Count - 1].getPunkt().getY() - 1) * si - 5);
        }

        public void sciana()
        {   SolidColorBrush brush = new SolidColorBrush(Colors.DarkSlateBlue);
            Rectangle rec = new Rectangle
            {
                Stroke = brush,
                Height = canvas.Height+2,
                Width = canvas.Width+2
            };
            canvas.Children.Add(rec);
            Canvas.SetLeft(rec, -1);
            Canvas.SetTop(rec, -1);
        }
        public void food(Food fod)
        {
            Image ima = new Image
            {
                Height = si,
                Width = si
            };
            Image ima1 = new Image
            {
                Height = 400,
                Width = 400
            };
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri ("/Files/Szachownica.jpg", UriKind.Relative);
            bi1.EndInit();
            ima1.Source = bi1;
            canvas.Children.Add(ima1);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Files/Food2.png", UriKind.Relative);
            bi.EndInit();
            ima.Source = bi;
            canvas.Children.Add(ima);
            Canvas.SetLeft(ima, (fod.getPunkt().getX()-1) * si);
            Canvas.SetTop(ima, (fod.getPunkt().getY()-1) * si);
        }
        public void printSnake(List<Element> list)
        {
            Image imag=new Image();
            foreach (Element e in list)
            {
                Image ima = new Image
                {
                    Height = si,
                    Width = si
                };
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri("/Files/snake.png", UriKind.Relative);
                bi.EndInit();
                ima.Source = bi;
                canvas.Children.Add(ima);
                Canvas.SetLeft(ima, (e.getPunkt().getX()-1) * si);
                Canvas.SetTop(ima, (e.getPunkt().getY()-1) * si);
                imag = ima;
            }
            if(list.Count>0)
            canvas.Children.Remove(imag);
            imag = new Image
            {
                Height = si,
                Width = si
            };
            BitmapImage bii = new BitmapImage();
            bii.BeginInit();
            bii.UriSource = new Uri("/Files/head.png", UriKind.Relative);
            bii.EndInit();
            imag.Source = bii;
            canvas.Children.Add(imag);
            Canvas.SetLeft(imag, (list[list.Count-1].getPunkt().getX()-1) * si);
            Canvas.SetTop(imag, (list[list.Count - 1].getPunkt().getY()-1) * si);
        }
        private void KeyEvent(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                if (snake.getDx() != 0 && snake.getMoved() == false)
                { snake.setDx(0); snake.setDy(-1); snake.setMoved(true); }
            }
            if (e.Key == Key.Down)
            {
                if (snake.getDx() != 0 && snake.getMoved() == false)
                { snake.setDx(0); snake.setDy(1); snake.setMoved(true); }
            }
            if (e.Key == Key.Left)
            {
                if (snake.getDy() != 0 && snake.getMoved() == false)
                { snake.setDy(0); snake.setDx(-1); snake.setMoved(true); }
            }
            if (e.Key == Key.Right)
            {
                if (snake.getDy() != 0 && snake.getMoved() == false)
                { snake.setDy(0); snake.setDx(1); snake.setMoved(true); }
            }
        }
        }
}
