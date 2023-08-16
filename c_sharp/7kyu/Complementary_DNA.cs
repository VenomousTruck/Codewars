// Complementary DNA

public class DnaStrand {
    public static string MakeComplement(string dna) {
        string str = "";

        for (int i = 0; i < dna.Length; i++) {
            if (dna[i] == 'A')
                str += 'T';
            if (dna[i] == 'T')
                str += 'A';
            if (dna[i] == 'G')
                str += 'C';
            if (dna[i] == 'C')
                str += 'G';
        }

        return str;
    }
}