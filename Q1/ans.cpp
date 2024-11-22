#include <iostream>
#include <map>
#include <string>
using namespace std;

int main() {
    string input = "mohammad";
    map<char, int> counts;

    for (char c : input) {
        counts[c]++;
    }

    for (auto pair : counts) {
        cout << pair.first << ": " << pair.second << endl;
    }

    return 0;
}
