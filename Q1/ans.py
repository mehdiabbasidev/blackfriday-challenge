def count_characters(s):
    counts = {}
    for char in s:
        counts[char] = counts.get(char, 0) + 1
    for char, count in counts.items():
        print(f"{char}: {count}")

count_characters("mohammad")
