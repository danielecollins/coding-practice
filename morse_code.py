# Morse code dictionary
morse_code = {
    'A': '.-',
    'B': '-...',
    'C': '-.-.',
    'D': '-..',
    'E': '.',
    'F': '..-.',
    'G': '--.',
    'H': '....',
    'I': '..',
    'J': '.---',
    'K': '-.-',
    'L': '.-..',
    'M': '--',
    'N': '-.',
    'O': '---',
    'P': '.--.',
    'Q': '--.-',
    'R': '.-.',
    'S': '...',
    'T': '-',
    'U': '..-',
    'V': '...-',
    'W': '.--',
    'X': '-..-',
    'Y': '-.--',
    'Z': '--..',
    '1': '.----',
    '2': '..---',
    '3': '...--',
    '4': '....-',
    '5': '.....',
    '6': '-....',
    '7': '--...',
    '8': '---..',
    '9': '----.',
    '0': '-----',
}

# The purpose of this function is to decrypt the morse code
def decrypt(message):
    space_count = 0
    code_str = ''
    word = ''
    sentence = ''

    # Traverse the message, the f is added as flag for the end of the message
    for char in message + 'f':
        # If there is a space or an f then translate the letter and add it to the word
        if char == ' ' or char == 'f':
            space_count += 1
            for letter, code in morse_code.items():
                if code_str == code:
                    word += letter
                    code_str = ''
                    break
        # Otherwise add the character to the morse code string
        else:
            code_str += char
            space_count = 0

        # Check the number of spaces. If 2 spaces in a row or the flag is found: add the word the sentence
        if space_count == 2:
            sentence += word + ' '
            word = ''
        elif char == 'f':
            sentence += word
            word = ''          
        
    return sentence

# Check if the morse code is valid
def input_is_valid(message):
    for char in message:
        if char != '-' and char != '.' and char != ' ':
            return False
    return True

keep_going = 'y'

while keep_going == 'y':
    message = input("Enter Morse code to decrypt, seperate letters by 1 space & words by 2 spaces: ")

    while not input_is_valid(message):
        message = input("Morse code invalid, please try again. Remember to seperate letters by 1 space & words by 2 spaces: ")

    print(decrypt(message))
    keep_going = input("Would you like to decrypt another message? (y/n) ")