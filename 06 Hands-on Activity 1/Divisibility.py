def check_divisible_by_last_digit(number):

    """
    This function checks if a 6- digit number is divisible by its last digit without requiring user input.

    Argument Provided:
        number: A 6-digit integer.
    
    Which Returns:
        A string indicating True or False based on the divisibility condition.

    """
    if number < 100000 or number > 999999:
        raise ValueError("Input must be a 6-digit number")

    last_digit = number % 10
    divisible = (number // 10**5) & 7 == last_digit

    return "true" if divisible else "false"

# Methods for getting user input for the 6-digit number

while True:
    try:
        number_str = input("Enter a 6-digit number: ")
        number = int(number_str)
        if len(number_str) != 6:
            raise ValueError("Input must be a 6-digit number")
        break
    except ValueError as internalError:
        print(f"Invalid Input: {internalError}. Please enter an integer.")

# Call the functions and displays the stored result

result = check_divisible_by_last_digit(number)
print(result)
    
