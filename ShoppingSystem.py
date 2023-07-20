# Simple program written in Python that literally just imitates a online shop
# It has a working shopping cart where you can remove items and such
# Doesn't have an interface, basically a CLI

# Menu items and Prices 
menu = {
    
    'Perfect Grade': {
        '1': {'name': 'GUNDAM RAISER', 'price': 315.0},
        '2': {'name': 'Gundam SEED Astray', 'price': 320.0},
        '3': {'name': 'Wing Gundam', 'price': 350.0},
        '4': {'name': 'Freedom Gundam', 'price': 410.0}
    },
    'Real Grade': {
        '5': {'name': 'RG GoldyMarg', 'price': 52.0},
        '6': {'name': 'RG Gao Gai Gar', 'price': 78.0},
        '7': {'name': 'God Gundam', 'price': 58.0},
        '8': {'name': 'Wing Gundam Astray', 'price': 38.0}
    },
    'Master Grade': {
        '9': {'name': 'Eclipse Gundam', 'price': 195.0},
        '10': {'name': 'Full Saber', 'price': 72.0},
        '11': {'name': 'Unicorn Gundam', 'price': 64.0},
        '12': {'name': 'Gundam Dynames', 'price': 56.0}
    },
    'Mecha Girl': {
        '13': {'name': 'Messiah Ranka Lee', 'price': 95.0},
        '14': {'name': 'Ganesa', 'price': 20.0},
        '15': {'name': 'Arcanadea Lumitea', 'price': 75.0},
        '16': {'name': 'Tsubasa Kazanari', 'price': 90.0}
    },
    'Motorized': {
        '17': {'name': 'Little Ryan', 'price': 30.0},
        '18': {'name': 'Elephant Racer', 'price': 17.0},
        '19': {'name': 'Zoids Stylaser', 'price': 148.0},
        '20': {'name': 'Cannon Bull', 'price': 35.0}
    }

}

# For Initializing the Shopping Cart
shopping_cart = {}

# For Displaying the Menu and for Category Selection
def display_name():
    print('Menu Categories:')
    for category in menu:
        print(f'{category}:')
        for item_id, item in menu[category].items():
            print(f'ID: {item_id}, Item: {item["name"]}, Price: ${item["price"]}')
        print()

# Adding items to the shopping cart
def add_to_cart(category, item_id, quantity):
    item = menu[category][item_id]
    if item_id in shopping_cart:
        shopping_cart[item_id]['quantity'] += quantity
    else:
        shopping_cart[item_id] = {'name': item['name'], 'price': item['price'], 'quantity': quantity}

# Editing item quantity in the shopping cart
def edit_cart(item_id, new_quantity):
    if item_id in shopping_cart:
        shopping_cart[item_id]['quantity'] = new_quantity

# Removing items from the shopping cart
def remove_from_cart(item_id):
    if item_id in shopping_cart:
        del shopping_cart[item_id]

# Calculation of the total price of the shopping cart
def calculate_total_price():
    total_price = 0.0
    for item_id, item in shopping_cart.items():
        total_price += item['price'] * item['quantity']
        return total_price
    
# Application of discount to the total prices depending on the privilege level
def apply_discount(total_price, privilege_level):
    discount_percentage = 0.0
    if privilege_level == 'Gold':
        discount_percentage = 0.15
    elif privilege_level == 'Silver':
        discount_percentage = 0.1
    elif privilege_level == 'Bronze':
        discount_percentage = 0.05
    return total_price - (total_price * discount_percentage)

# Calculation of the GST amount
def calculate_gst(total_price):
    gst_rate = 0.09
    return total_price * gst_rate

# Displaying the final bill statement
def display_bill(privilege_level):
    total_price = calculate_total_price()
    discounted_price = apply_discount(total_price, privilege_level)
    gst_amount = calculate_gst(discounted_price)
    final_price = discounted_price + gst_amount

    print('Bill Statement:')
    print('---------------------------')
    for item_id, item in shopping_cart.items():
        print (f'Item: {item["name"]}, Quantity: {item["quantity"]}, Price: ${item["price"] * item["quantity"]}')
    print('---------------------------')
    print(f'Total Price (Before Discount): ${total_price}')
    print(f'Discounted Price: ${discounted_price}')
    print(f'GST (9%): ${gst_amount}')
    print(f'Final Payable Amount: ${final_price}')

# Now the Main Program Loop
def payment_system():
    print('Welcome to the Payment System!')

    while True:
        display_name()
        category = input('Please Enter the Category ID to select a category (or "exit" to quit): ')

        if category == 'exit':
            break

        if category in menu:
            while True:
                item_id = input('Please Enter the Item ID to add to cart (or "back" to go back to category selection): ')

                if item_id == 'back':
                    break

                if item_id in menu[category]:
                    quantity = int(input('Please enter the quantity: '))
                    add_to_cart(category, item_id, quantity)
                    print('Item added to cart successfully!')
                else:
                    print('You have entered an invalid item id. Please try again.')
        else:
            print('You have entered an invalid category ID. Please try again.')
    print('Shopping Cart:')
    print('-----------------------------------')
    for item_id, item in shopping_cart.items():
        print(f'Item: {item["name"]}, Quantity: {item["quantity"]}')
    print('-----------------------------------')

    while True:
        edit_choice = input('Do you want to edit the shopping cart? (yes/no): ')

        if edit_choice.lower() == 'no':
            break

        if edit_choice.lower() == 'yes':
            item_id = input('Enter the item ID to edit: ')

            if item_id in shopping_cart:
                new_quantity = int(input('Please enter the new quantity: '))
                edit_cart(item_id, new_quantity)
                print('Shopping cart updated successfully!')
            else:
                print('You have entered an invalid item ID. Please try again.')
    
    while True:
        remove_choice = input('Do you want to remove any item from the shopping cart? (yes/no): ')


        if remove_choice.lower() == 'no':
            break

        if remove_choice.lower() == 'yes':
            item_id = input('Please enter the item ID to remove: ')

            if item_id in shopping_cart:
                remove_from_cart(item_id)
                print('Item removed from cart successfully!')
            else:
                print('Invalid item ID. Please try again.')
    
    print('Final Shopping Cart:')
    print('-----------------------------------')
    for item_id, item in shopping_cart.items():
        print(f'Items {item["name"]}, Quantity: {item["quantity"]}')
    print('-----------------------------------')

    privilege_level = input('Please enter your discount privilege level (Gold/Silver/Bronze): ')
    display_bill(privilege_level)

# Start the payment system
payment_system()



    