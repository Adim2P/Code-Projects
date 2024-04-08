def get_secondary_color(color1, color2):

    color1 = color1.lower()
    color2 = color2.lower()

    primary_colors = ["red", "blue", "yellow"]

    if color1 == "red" and color2 == "blue":
        return "purple"
    elif color1 == "yellow" and color2 == "blue":
        return "green"
    elif color1 == "yellow" and color2 == "red":
        return "orange"
    else:
        return "Invalid Color Combination"
    
color1 = input("Enter first primary color (red, blue, yellow): ")
color2 = input("Enter secondary primary color (red, blue, yellow): ")

secondary_color = get_secondary_color(color1, color2)

print("The secondary color is:", secondary_color)