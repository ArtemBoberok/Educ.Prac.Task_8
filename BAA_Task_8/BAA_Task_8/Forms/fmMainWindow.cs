using BAA_Task_8.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BAA_Task_8.Forms
{
    public partial class fmMainWindow : Form
    {
        int _itemcount = 0;
        public fmMainWindow(string userRole, string name)
        {
            InitializeComponent();
            labelStripRole.Text += userRole;
            labelStripName.Text += name;
            LoadAndInitData();

            var CategoryType = Shop_BAAEntities.GetContext().Categories.OrderBy(p => p.CategoryName).ToList();
            CategoryType.Insert(0, new Category { CategoryName = "Все типы" });
            comboBoxCat.DataSource = CategoryType;
            comboBoxCat.DisplayMember = "CategoryName";
            comboBoxCat.ValueMember = "CategoryId";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        // Метод загрузки данных о товаре в таблицу
        private void LoadAndInitData()
        {
            // Получение данных из бд
            var currentGoods = Shop_BAAEntities.GetContext().Goods.Join
            (Shop_BAAEntities.GetContext().Categories, p => p.CategoryId, t => t.CategoryId,
            (p, t) => new { p.GoodName, p.Price, p.Picture, p.Descriptions, t.CategoryName, p.CategoryId }).ToList();

            // В качестве источника данных присваиваем список
            dataGridViewGood.DataSource = currentGoods;

            // Убираем вывод id
            dataGridViewGood.Columns[5].Visible = false;

            // Загаловки столбцов
            dataGridViewGood.Columns[0].HeaderText = "Название";
            dataGridViewGood.Columns[1].HeaderText = "Цена";
            dataGridViewGood.Columns[2].HeaderText = "Изображение";
            dataGridViewGood.Columns[3].HeaderText = "Описание";
            dataGridViewGood.Columns[4].HeaderText = "Категории";

            // Кол-во товаров
            _itemcount = dataGridViewGood.Rows.Count;
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        // Метод для фильтрации и сортировки данных
        private void UpdateData()
        {
            // Получение данных из бд
            var currentGoods = Shop_BAAEntities.GetContext().Goods.Join
            (Shop_BAAEntities.GetContext().Categories, p => p.CategoryId, t => t.CategoryId,
            (p, t) => new { p.GoodName, p.Price, p.Picture, p.Descriptions, t.CategoryName, p.CategoryId }).ToList();

            // Выбор только тех товаров, которые принадлежат данной категории
            if (comboBoxCat.SelectedIndex > 0)
                currentGoods = currentGoods.Where(y => y.CategoryId == (comboBoxCat.SelectedItem as Category).CategoryId).ToList();

            // Выбор тех товаров, в названии которых есть поисковая строка
            currentGoods = currentGoods.Where(p => p.GoodName.ToLower().Contains(textBoxNameGood.Text.ToLower())).ToList();

            // Сортировка по цене
            if (comboBoxSort.SelectedIndex >= 0)
            {
                // Сортировка по возростанию цены 
                if (comboBoxSort.SelectedIndex == 0)
                    currentGoods = currentGoods.OrderBy(p => p.Price).ToList();

                // Сортировка по убыванию цены 
                if (comboBoxSort.SelectedIndex == 1)
                    currentGoods = currentGoods.OrderByDescending(p => p.Price).ToList();

                // Сортировка по названию
                if (comboBoxSort.SelectedIndex == 2)
                    currentGoods = currentGoods.OrderBy(p => p.GoodName).ToList();
            }

            // В качестве источника данных присваиваем список
            dataGridViewGood.DataSource = currentGoods;

            // Убираем вывод id
            dataGridViewGood.Columns[5].Visible = false;

            // Отображение кол-ва записей
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        private void textBoxNameGood_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridViewGood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = dataGridViewGood[0, e.RowIndex].Value.ToString();
            labelNameGood.Text = dataGridViewGood[0, e.RowIndex].Value.ToString();
            labelPrice.Text = dataGridViewGood[1, e.RowIndex].Value.ToString();
            pictureBoxGood.Image = Image.FromFile(Directory.GetCurrentDirectory()
                + @"\Images\" + dataGridViewGood[2, e.RowIndex].Value.ToString());
        }

        private void fmMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
