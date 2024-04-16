def calculate_kinetic_energy(mass, velocity):

    kinetic_energy = 0.5 * mass * velocity **2
    return kinetic_energy

mass = float(input("Enter object's mass (kg): "))
velocity = float(input("Enter object's velocity (m/s): "))

kinetic_energy = calculate_kinetic_energy(mass, velocity)
print(f"The object's kinetic energy is: {kinetic_energy: .2f} joules")