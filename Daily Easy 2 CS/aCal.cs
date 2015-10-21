

namespace Daily_Easy_2_CS
{
    class aCal : iCal
    {

        public int mass = 0;
        public int acceleration = 0;
        public int force = 0;

        public int getAcceleration()
        {
            return acceleration;
        }

        public int getForce()
        {
            return force;
        }

        public int getMass()
        {
            return mass;
        }

        public void setAcceleration(int acceleration)
        {
            this.acceleration = acceleration;
        }

        public void setForce(int force)
        {
            this.force = force;
        }

        public void setMass(int mass)
        {
            this.mass = mass;
        }
    }
}
