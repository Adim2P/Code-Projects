def bacterial_growth(initial_count, num_hours):

    """
    Calculates the number of bacteria for each hour based on initial count and duration

    Definition arguments:
    initial_count = used as the initial number of bacteria.
    num_hours = The number of hours to simulate.

    Returning Arguments:
    A list containing the number of bacteria at the end of each hour.
    
    """

    bacteria_population = [initial_count]

    for hour in range(1, num_hours + 1):
        fissions = hour - 1     # Number of fissions in the current hour
        bacteria_count = initial_count * 2**fissions
        bacteria_population.append(bacteria_count)

    return bacteria_population

# User Input for initial count and number of hours

initial_count = int(input("Enter the initial count of bacteria: "))
num_hours = int(input("Enter the number of hours: "))

# Calculate and prints the bacteria population per hour

bacteria_population = bacterial_growth(initial_count, num_hours)
print("The number of bacteria per hour will be: ")
for hour, count in enumerate(bacteria_population, start=1):
    print(f"Hour {hour} = {count}")