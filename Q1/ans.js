function countCharacters(input) {
    const counts = {};
    for (const char of input) {
        counts[char] = (counts[char] || 0) + 1;
    }
    for (const [char, count] of Object.entries(counts)) {
        console.log(`${char}: ${count}`);
    }
}


countCharacters("mohammad");
