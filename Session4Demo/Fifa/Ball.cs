using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Fifa
{
    internal struct Ball
    {

        //public List<Player> players {  get; set; } = new List<Player>();
        //public List<Refree> Refree {  get; set; } = new List<Refree>();
        //public List<Coach> coaches {  get; set; } = new List<Coach>();

        public int Id { get; set; }
        private Location location;

        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                if (BallLocationChange is not null)
                    BallLocationChange.Invoke(this);
            }
        }


        public Action<Ball> BallLocationChange;

        public override string ToString()
        {
            return $"Id : {Id} , Location : {location}";
        }

    }
}
 