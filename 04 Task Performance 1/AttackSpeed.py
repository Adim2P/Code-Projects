def attack_speed(base_speed, bonus_pct, level):

    bonus_dec = bonus_pct / 100
    current_speed = base_speed * (1 + (bonus_dec * (level - 1 )))
    current_speed = round(current_speed, 3)

    return current_speed

base_speed = float(input("Enter base attack speed: "))
bonus_pct = float(input("Enter bonus attack speed percentage (e.g., 5 for 5%): "))
level = int(input("Enter character level: "))

current_speed = attack_speed(base_speed, bonus_pct, level)
print(f"Character's current attack speed: {current_speed:.3f}")