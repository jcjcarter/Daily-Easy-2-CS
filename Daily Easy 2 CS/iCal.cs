

namespace Daily_Easy_2_CS
{
    interface iCal
    {
        /// <summary>
        /// Sets the mass. 
        /// </summary>
        /// <param name="mass"></param>
        void setMass(int mass);

        /// <summary>
        /// Sets the acceleration. 
        /// </summary>
        /// <param name="acceleration"></param>
        void setAcceleration(int acceleration);

        /// <summary>
        /// Sets the force.
        /// </summary>
        /// <param name="force"></param>
        void setForce(int force);

        /// <summary>
        /// Gets the mass.
        /// </summary>
        /// <returns> The mass. </returns>
        int getMass();

        /// <summary>
        /// Gets the acceleration.
        /// </summary>
        /// <returns> The acceleration. </returns>
        int getAcceleration();

        /// <summary>
        /// Get the force.
        /// </summary>
        /// <returns> The force. </returns>
        int getForce();
    }
}
