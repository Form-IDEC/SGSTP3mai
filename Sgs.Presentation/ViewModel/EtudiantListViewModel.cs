using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sgs.Business.Model;
using System.Collections.ObjectModel;
using Sgs.Persistance.EntityModel;

namespace Sgs.Presentation.ViewModel
{
    public class EtudiantListViewModel
    {
        private ObservableCollection<tbEtudiants> _etudiants;

        public EtudiantListViewModel()
        {
            EntityModelConnexion context = new EntityModelConnexion();
            _etudiants = new ObservableCollection<tbEtudiants>(context.tbEtudiants);

            //foreach (tbEtudiants etudiant in context.tbEtudiants.ToList<tbEtudiants>())
            //    _etudiants.Add(etudiant);
                       
        
           
          
        }

        public ObservableCollection<tbEtudiants> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;
            }
        }

      


    }
}
