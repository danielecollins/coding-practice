def count_a(base_str, n):
    i = 0
    index = 0
    last_index = len(base_str)-1
    a_count = 0

    while i < n:
        if base_str[index] == 'a':
            a_count += 1

        if last_index == index:
            index = 0
        else:
            index += 1

        i += 1

    return a_count

print(count_a("abcdaafdslfsdjfla", 100))