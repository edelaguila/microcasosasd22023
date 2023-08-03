using Software_de_taquilla.Views.AdminViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Models.Dao;

namespace Software_de_taquilla.Controllers
{
    public class HorarioController
    {
        public Horarios view;
        public List<Movie> movies = new List<Movie>();
        public List<Schedule> horarios = new List<Schedule>();
        public HorarioController(Horarios view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
        }

        public bool isFree(string hour)
        {
            foreach (Schedule sc in horarios)
            {
                if (sc.h_start.Equals(hour)) return false;
            }
            return true;
        }

        public string getMovieName(int id)
        {
            foreach (Movie mov in movies)
            {
                if (mov.id.Equals(id)) return mov.name;
            }
            return "";
        }

        public int getMovieId(string name)
        {
            foreach (Movie mov in movies)
            {
                if (mov.name.Equals(name)) return mov.id;
            }
            return -1;
        }

        public void fillData()
        {
            ScheduleDao sch = new ScheduleDao();
            this.horarios = sch.getSchedules();
            this.view.data_grid.Rows.Clear();
            this.view.data_grid.ColumnCount = 4;
            this.view.data_grid.Columns[0].Name = "ID";
            this.view.data_grid.Columns[1].Name = "Hora Inicio";
            this.view.data_grid.Columns[2].Name = "Hora Fin";
            this.view.data_grid.Columns[3].Name = "Pelicula";
            foreach (Schedule sc in horarios)
            {
                this.view.data_grid.Rows.Add(sc.id, sc.h_start, sc.h_final, this.getMovieName(sc.id_movie));
            }
        }


        public void buildComponent(Object sender, EventArgs e)
        {
            MovieDao mdao = new MovieDao();
            this.movies = mdao.getMovies();
            ScheduleDao dao = new ScheduleDao();
            this.horarios = dao.getSchedules();
            this.fillMoviesCombo();
            this.fillData();

            this.view.btn_save.Click += new EventHandler(saveClick);
            this.view.btn_delete.Click += new EventHandler(deleteClick);
        }

        public void deleteClick(Object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[0].Value);
            ScheduleDao sc = new ScheduleDao();
            sc.deleteSchedule(id);
            this.view.printMessage("Horario Eliminado");
            this.fillData();
        }

        public void saveClick(Object sender, EventArgs e)
        {
            string hi = this.view.txt_hi.Text;
            string hf = this.view.txt_hf.Text;
            string movie_selected = this.view.combo_movie.Text;
            int id_movie = this.getMovieId(movie_selected);
            ScheduleDao dao = new ScheduleDao();
            dao.insertarSchedule(new Schedule(hi, hf, id_movie));
            this.view.clearTextBox();
            this.view.printMessage("Horario Guardado");
            this.fillData();
        }

        public void fillMoviesCombo()
        {
            foreach (Movie mov in movies)
            {
                this.view.combo_movie.Items.Add(mov.name);
            }
        }
    }
}
