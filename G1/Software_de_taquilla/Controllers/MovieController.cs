using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Mozilla;
using Software_de_taquilla.Views.AdminViews;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;
using System.IO;
using System.Text;
using System.Linq;


namespace Software_de_taquilla.Controllers
{
    public class MovieController
    {
        MovieManagment view;
        public MovieController(MovieManagment view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
            this.view.btn_save.Click += new EventHandler(this.saveMovie);
            this.view.btn_update.Click += new EventHandler(this.updateClick);
            this.view.btn_delete.Click += new EventHandler(this.delete);
        }

        public void delete(Object sender, EventArgs e)
        {
            MovieDao dao = new MovieDao();
            int id = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[0].Value);
            dao.deleteMovie(id);
            this.view.printMessage("Pelicula Eliminada");
            this.fillDataGrid();
        }

        public void updateMovie()
        {
            string name = view.txt_name.Text;
            string publico = view.txt_publico.Text;
            string d = view.txt_duracion.Text;
            int listing = Convert.ToInt32(view.list_listing.Text);
            int room = Convert.ToInt32(view.room_listing.Text);
            string image = view.image_location;
            string image_name = getImageName(image);
            MovieDao dao = new MovieDao();
            int id = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[0].Value);
            dao.updateMovie(id, name, image_name, d, listing, room, publico);
            this.deleteImage(image_name);
            this.view.btn_save.BackColor = Color.SeaGreen;
            view.printMessage("Pelicula Actualizada");
            view.clearTextBox();
            this.fillDataGrid();
        }

        public void updateClick(Object sender, EventArgs e)
        {
            this.view.btn_save.BackColor = Color.LightYellow;
            this.view.btn_save.ForeColor = Color.Black;
            this.view.btn_save.Text = "Actualizar";
            this.view.panel_picture.BackgroundImage = null;
        }

        public void saveMovie(Object sender, EventArgs e)
        {
            if (this.view.btn_save.BackColor == Color.LightYellow)
            {
                this.updateMovie(); return;
            }
            string name = view.txt_name.Text;
            string publico = view.txt_publico.Text;
            string d = view.txt_duracion.Text;
            int listing = Convert.ToInt32(view.list_listing.Text);
            int room = Convert.ToInt32(view.room_listing.Text);
            string image = view.image_location;
            string image_name = getImageName(image);
            MovieDao dao = new MovieDao();
            dao.insertMovie(name, image_name, d, listing, room, publico);
            this.saveImage(image, image_name);
            view.printMessage("Pelicula Agregada");
            view.clearTextBox();
            this.fillDataGrid();
        }

        public string getImageName(string image)
        {
            int pos = image.LastIndexOf("\\");
            return image.Substring(pos).Remove(0, 1);
        }

        public void saveImage(string path, string image)
        {
            File.Copy(path, "./../../../images/" + image);
        }

        public void deleteImage(string image)
        {
            File.Delete("./../../../images/" + image);
        }
        public void buildComponent(Object sender, EventArgs e)
        {
            this.fillDataGrid();
            this.fillListings();
            this.fillRooms();
        }

        public void fillRooms()
        {
            RoomDao dao = new RoomDao();
            List<Room> rooms = dao.getRooms();
            foreach (Room r in rooms)
            {
                this.view.room_listing.Items.Add(r.id);
            }
        }

        public void fillListings()
        {
            ListingDao dao = new ListingDao();
            List<Listing> lists = dao.getListings();
            foreach (Listing l in lists)
            {
                this.view.list_listing.Items.Add(l.id);
            }
        }


        public void fillDataGrid()
        {
            view.data_grid.Rows.Clear();
            MovieDao dao = new MovieDao();
            List<Movie> movies = dao.getMovies();
            view.data_grid.ColumnCount = 6;
            view.data_grid.Columns[0].Name = "ID";
            view.data_grid.Columns[1].Name = "Nombre";
            view.data_grid.Columns[2].Name = "Publico";
            view.data_grid.Columns[3].Name = "Duracion";
            view.data_grid.Columns[4].Name = "Cartelera";
            view.data_grid.Columns[5].Name = "Sala";
            foreach (Movie movie in movies)
            {
                view.data_grid.Rows.Add(movie.id, movie.name, movie.public_, movie.duration, movie.id_listing, movie.id_room);
            }
        }
    }
}



