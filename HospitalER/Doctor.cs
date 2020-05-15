using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace HospitalER
{
    [Serializable]
    public class Doctor : Person
    {
        #region ATTRIBUTES
        
        [NonSerialized]
        private int idDoctor;
        
        private bool operational;

        #endregion

        #region properties
        /// <summary>
        /// Gives and receaves the value of the variable
        /// </summary>
        /// <value></value>
        public int IdDoctor
        {
            get => idDoctor;
            set => idDoctor = value;
        }
        /// <summary>
        /// Gives and receaves the value of the variable
        /// </summary>
        /// <value></value>
        public override string Name
        {
            get => name;
            set => name = value;
        }
        /// <summary>
        /// Gives and receaves the value of the variable
        /// </summary>
        /// <value></value>
        public override string BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }
        /// <summary>
        /// Gives and receaves the value of the variable
        /// </summary>
        /// <value></value>
        public override string CC
        {
            get => cc;
            set => cc = value;
        }
        /// <summary>
        /// Gets or sets address value
        /// </summary>
        public override string Address
        {
            get => address;
            set => address = value;
        }
        /// <summary>
        /// Gives and receaves the value of the variable
        /// </summary>
        /// <value></value>
        public bool Operational
        {
            get => operational;
            set => operational = value;
        }

        #endregion

        #region METHODS

        #region CONSTRUCTORS 
        /// <summary>
        /// Creates a new object of the class
        /// </summary>
        public Doctor()
        {
            this.idDoctor = Doctors.nDoctors + 1;
            this.name = "";
            this.birthDate = "";
            this.cc = "";
            this.address = "";
            this.operational = true;
        }
        /// <summary>
        /// Create a new Doctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="cc"></param>
        public Doctor(string name, string birthDate, string cc, string address)
        {
            this.idDoctor++;
            this.name = name;
            this.birthDate = "";
            this.cc = cc;
            this.address = address;
        }

        #endregion
            
        
        #endregion



    }
}