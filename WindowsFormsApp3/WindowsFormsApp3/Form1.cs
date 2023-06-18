using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private List<Room> rooms;
        private List<Client> clients;
        private object occupiedRoomsTabPage;
        private object availableRoomsTabPage;

        public Form1()
        {
            InitializeComponent();
            rooms = new List<Room>();
            clients = new List<Client>();

            // Додати деякі тестові дані про номери готелю
            rooms.Add(new Room("101", RoomClass.Standard));
            rooms.Add(new Room("202", RoomClass.SemiLuxury));
            rooms.Add(new Room("303", RoomClass.Luxury));
            DesignForm();

        }
        private void DesignForm()
        {
            // Зміна дизайну кнопок
            VIEW_OK.BackColor = Color.Blue;
            VIEW_OK.ForeColor = Color.White;
            VIEW_OK.Font = new Font("Arial", 12, FontStyle.Bold);

            VIEW_AV.BackColor = Color.Green;
            VIEW_AV.ForeColor = Color.White;
            VIEW_AV.Font = new Font("Arial", 12, FontStyle.Bold);

            CheckLn.BackColor = Color.Red;
            CheckLn.ForeColor = Color.White;
            CheckLn.Font = new Font("Arial", 12, FontStyle.Bold);

            CheckOut.BackColor = Color.Orange;
            CheckOut.ForeColor = Color.White;
            CheckOut.Font = new Font("Arial", 12, FontStyle.Bold);

            // Зміна дизайну текстового поля
            textBox1.BackColor = Color.LightYellow;
            textBox1.Font = new Font("Arial", 12);

            // Зміна дизайну лістбоксів
            roomsListBox.BackColor = Color.White;
            roomsListBox.Font = new Font("Arial", 12);

            occupiedRoomsListBox.BackColor = Color.White;
            occupiedRoomsListBox.Font = new Font("Arial", 12);

            availableRoomsListBox.BackColor = Color.White;
            availableRoomsListBox.Font = new Font("Arial", 12);

          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshRoomList();
        }

        private void RefreshRoomList()
        {
            roomsListBox.Items.Clear();

            foreach (var room in rooms)
            {
                roomsListBox.Items.Add($"{room.Number} ({room.RoomClass}) - {(room.IsOccupied ? "Зайнятий" : "Вільний")}");
            }
        }

        private void VIEW_OK_Click(object sender, EventArgs e)
        {
            occupiedRoomsListBox.Items.Clear();

            foreach (var room in rooms)
            {
                if (room.IsOccupied)
                {
                    occupiedRoomsListBox.Items.Add($"{room.Number} ({room.RoomClass})");
                }
            }

            tabControl1.SelectedTab = occupied;
        }

        private void VIEW_AV_Click(object sender, EventArgs e)
        {
            availableRoomsListBox.Items.Clear();

            foreach (var room in rooms)
            {
                if (!room.IsOccupied)
                {
                    availableRoomsListBox.Items.Add($"{room.Number} ({room.RoomClass})");
                }
            }

            tabControl1.SelectedTab = available;
        }

        private void CheckLn_Click(object sender, EventArgs e)
        {
            string roomNumber = availableRoomsListBox.SelectedItem?.ToString().Split(' ')[0];
            if (roomNumber != null)
            {
                var clientName = textBox1.Text;

                if (!string.IsNullOrEmpty(clientName))
                {
                    rooms.Find(r => r.Number == roomNumber).IsOccupied = true;
                    clients.Add(new Client(clientName, roomNumber));

                    MessageBox.Show($"Клієнт {clientName} успішно заселений в номер {roomNumber}", "Заселення клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshRoomList();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Введіть ім'я клієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Виберіть вільний номер для заселення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            string roomNumber = occupiedRoomsListBox.SelectedItem?.ToString().Split(' ')[0];
            if (roomNumber != null)
            {
                var client = clients.Find(c => c.RoomNumber == roomNumber);

                rooms.Find(r => r.Number == roomNumber).IsOccupied = false;
                clients.Remove(client);

                MessageBox.Show($"Клієнт {client.Name} успішно виселений з номера {roomNumber}", "Виселення клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshRoomList();
            }
            else
            {
                MessageBox.Show("Виберіть зайнятий номер для виселення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void occupiedRoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availableRoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Room
    {
        public string Number { get; set; }
        public RoomClass RoomClass { get; set; }
        public bool IsOccupied { get; set; }

        public Room(string number, RoomClass roomClass)
        {
            Number = number;
            RoomClass = roomClass;
            IsOccupied = false;
        }
    }

    public enum RoomClass
    {
        Standard,
        SemiLuxury,
        Luxury
    }

    public class Client
    {
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public Client(string name, string roomNumber)
        {
            Name = name;
            RoomNumber = roomNumber;
        }
    }
}




