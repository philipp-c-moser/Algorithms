def search(list, item):

    # In which part of the list should be searched?
    low = 0   
    high = len(list) - 1 

    # As long as there are unsearched elements
    while low <= high:

        # Check the element in the middle
        mid = (low + high)
        guess = list[mid]

        # The searched element has been found
        if guess == item:
            return mid

        # The guessed value was too high
        if guess > item:
            high = mid -1

        # The guessed value was too low
        else:
            low = mid + 1

    # Element not part of the list
    return None


pool = [15, 27, 16, 14, 6, 23, 2, 26, 28, 13, 24, 20, 21, 12, 8]

print("Position for Number 2: ", search(pool, 2))
print("Position for Number 20: ", search(pool, 20))
