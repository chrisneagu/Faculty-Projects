#include <iostream>
#include <string>
using namespace std;
//cerinta 1
enum TIP { COMERCIALA = 1, PRIVATA, NECUNOSCUTA };

class Banca {
	const int ID_Banca;
	char* denumire;
	string tara;
	double* venituri_anuale;
	int numar_elemente;
	bool multinationala;
	TIP tip;
public:
	static int nr_banci;

	const char* getInCaractere() const {
		switch(tip) {
		case COMERCIALA:
			return "comerciala";
		case PRIVATA:
			return "privata";
		case NECUNOSCUTA:
			return "necunoscuta";
		}
	}
	//cerinta 2
	Banca(string tara, double* elem, int nrElem, TIP tip) : ID_Banca(++nr_banci)
	{
		if (tara.empty())
			throw new exception("Tara este empty");
		else
			this->tara = tara;

		if (nrElem <= 0)
			throw new exception("Numar elemente <= 0");
		else
			numar_elemente = nrElem;

		if (elem == nullptr)
			throw new exception("Elemente este nullptr");
		else
		{
			venituri_anuale = new double[nrElem];
			for (int i = 0; i < nrElem; i++)
				venituri_anuale[i] = elem[i];
		}
		if (tip < 1 || tip>3)
			throw new exception("Tipul nu este intre 1 si 3");
		else
			this->tip = tip;

		this->denumire = new char[strlen("Necunoscuta") + 1];
		strcpy_s(this->denumire, strlen("Necunoscuta") + 1, "Necunoscuta");
	}
	//cerinta 3
	Banca(const Banca& b) : ID_Banca(++nr_banci) {

		this->denumire = new char[strlen(b.denumire)+1];
		strcpy_s(this->denumire, strlen(b.denumire) + 1, b.denumire);

		this->tara = b.tara;

		this->venituri_anuale = new double[b.numar_elemente];
		for (int i = 0; i < b.numar_elemente; i++)
			this->venituri_anuale[i] = b.venituri_anuale[i];

		this->numar_elemente = b.numar_elemente;
		this->tip = b.tip;
		this->multinationala = b.multinationala;
	}

	Banca& operator=(const Banca& b) {

		if (this != &b) {

			if (this->denumire != nullptr)
				delete[] this->denumire;
			
			if (this->venituri_anuale != nullptr)
				delete[] this->venituri_anuale;

			this->denumire = new char[strlen(b.denumire) + 1];
			strcpy_s(this->denumire, strlen(b.denumire) + 1, b.denumire);

			this->tara = b.tara;
			this->multinationala = b.multinationala;
			this->tip = b.tip;

			this->numar_elemente = b.numar_elemente;

			this->venituri_anuale = new double[b.numar_elemente];
			for (int i = 0; i < b.numar_elemente; i++)
				this->venituri_anuale[i] = b.venituri_anuale[i];
		}
		return *this;
	}

	//cerinta 4
	Banca() : ID_Banca(++nr_banci) {
		this->denumire = new char[strlen("Necunoscuta") + 1];
		strcpy_s(this->denumire, strlen("Necunoscuta") + 1, "Necunoscuta");
	}

	~Banca(){
		if (this->denumire != nullptr)
			delete[] denumire;
		if (this->venituri_anuale != nullptr)
			delete[] venituri_anuale;

		cout << "\nDestructor Banca " << ID_Banca<<'\n';
		nr_banci--;
	}

	//cerinta 5
	int getNumarElemente() {
		return numar_elemente;
	}

	int getID() {
		return ID_Banca;
	}

	char* getDenumire() {
		return denumire;
	}

	string getTara() {
		return tara;
	}

	double* getvenituri() {
		return venituri_anuale;
	}
	
	//cerinta 6
	void setDenumire(const char* denumire) {
		if (denumire != nullptr) {
			delete[] this->denumire;
			this->denumire = new char[strlen(denumire) + 1];
			strcpy_s(this->denumire, strlen(denumire) + 1, denumire);
		}
		else
			throw new exception("Denumire este nullptr");
	}

	void setTara(string tara) {
		if (!tara.empty())
			this->tara = tara;
		else
			throw new exception("Tara este empty");
	}

	void setvenituri(double* venituri, int nrElem) {
		if (venituri != nullptr && nrElem > 0) {
			delete[] this->venituri_anuale;
			this->numar_elemente = nrElem;
			this->venituri_anuale = new double[nrElem];
			for (int i = 0; i < nrElem; i++)
				this->venituri_anuale[i] = venituri[i];
		}
		else
			throw new exception("venituri este null sau nrElem <= 0");
	}

	void setNumarElem(int nrElem) {
		if (nrElem > 0)
			this->numar_elemente = nrElem;
		else
			throw new exception("Nr Elemente <=0");
	}

	//cerinta 7
	friend istream& operator>>(istream& in, Banca& b);
	friend ostream& operator<<(ostream& out, const Banca& b);

	//cerinta 8

	const Banca& operator--() {
		for (int i = 0; i < numar_elemente; i++)
			venituri_anuale[i]--;	
		return *this;
	}

	void operator()(double valoare) {
		if (valoare >= 0) {

			for (int i = 0; i < numar_elemente; i++)
				if (venituri_anuale[i] + valoare > DBL_MAX)
					throw new exception("Overflow");
				else
					venituri_anuale[i] += valoare;
		}
	}

	const Banca operator+(Banca& b) {
		Banca aux = *this; 
		delete[] aux.venituri_anuale;
		aux.numar_elemente = this->numar_elemente + b.numar_elemente;
		aux.venituri_anuale = new double[aux.numar_elemente];

		int i;
		for (i = 0; i < this->numar_elemente; i++)
			aux.venituri_anuale[i] = this->venituri_anuale[i];

		int k = 0;
		for (int j = i; j < aux.numar_elemente; j++) {
			aux.venituri_anuale[j] = b.venituri_anuale[k];
			k++;
		}
		return aux;
	}
	
	//cerinta 9

	void stergeVenit(double Venit) {
		int k = 0;
		for (int i = 0; i < numar_elemente; i++)
			if (venituri_anuale[i] == Venit)
				k++;

		if (k > 0){
			int j = 0;
			double* aux = new double[numar_elemente - k];
			for (int i = 0; i < numar_elemente; i++)
				if (venituri_anuale[i] != Venit)
					aux[j++] = venituri_anuale[i];
			numar_elemente -= k;
			delete[] venituri_anuale;
			venituri_anuale = aux;
		}
	}

	void AdaugaVenitLaSfarsit(double Venit) {
		double* aux = new double[numar_elemente+1];
		int i;
		for (i = 0; i < numar_elemente; i++)
			aux[i] = venituri_anuale[i];
		aux[i] = Venit;
		numar_elemente++;
		delete[] venituri_anuale;
		venituri_anuale = aux;
	}

	//cerinta 10

	double VenitMax() {
		if (numar_elemente >= 1) {
			double max = venituri_anuale[0];
			for (int i = 1; i < numar_elemente; i++)
				if (max < venituri_anuale[i])
					max = venituri_anuale[i];			
			return max;
		}
		else
			throw new exception("Nu avem elemente in vectorul de venituri anuale");
	}

	int VenitApMax() {
		if (numar_elemente >= 1) {
			int ap = 1;
			double max = venituri_anuale[0];
			for (int i = 1; i < numar_elemente; i++)
				if (max < venituri_anuale[i]) {
					max = venituri_anuale[i];
					ap = 1;
				}
				else if (max == venituri_anuale[i]) {
					ap++;
				}
			return ap;
		}
		else
			throw new exception("Nu avem elemente in vectorul de venituri anuale");
	}
	void AdaugaVenitLa(double Venit, int index) {

		if (index >= 0 && index < numar_elemente) {
			double* aux = new double[++numar_elemente];
			int i = 0;
			for (i = 0; i < index; i++)
				aux[i] = venituri_anuale[i];
			aux[i] = Venit;
			int k = i;
			for (int j = i + 1; j < numar_elemente; j++)
				aux[j] = venituri_anuale[k++];
			this->venituri_anuale = aux;
		}
		else
			throw new exception("Index invalid");
		
	}
};


istream& operator>>(istream& in, Banca& b) {
	char aux[100];
	cout << "Denumire= ";
	in >> aux;

	if (b.denumire != nullptr)
		delete[] b.denumire;

	b.denumire = new char[strlen(aux) + 1];
	strcpy_s(b.denumire, strlen(aux) + 1, aux);

	cout << "Tara: "; 
	in >> b.tara;

	cout << "Numar elemente "; 
	in >> b.numar_elemente;
	if (b.venituri_anuale != nullptr)
		delete[] b.venituri_anuale;
	b.venituri_anuale = new double[b.numar_elemente];
	for (int i = 0; i < b.numar_elemente; i++)
		in >> b.venituri_anuale[i];

	cout << "Este multinationala?"; 
	in >> b.multinationala;

	int auxTip;
	cout << "Tip = "; 
	in >> auxTip;
	switch (auxTip) {
	case 1:
		b.tip = COMERCIALA;
		break;
	case 2:
		b.tip = PRIVATA;
		break;
	case 3:
		b.tip = NECUNOSCUTA;
		break;
	}
	return in;

}

ostream& operator<<(ostream& out, const Banca& b) {
	out << "ID-ul Bancii " << b.ID_Banca << " ,denumirea " << b.denumire << " ,tara " << b.tara;
	(b.multinationala) ? out << " ,este multinationala" : out << " ,nu este multinationala ";
	out << " tip " << b.getInCaractere()<< " si veniturile : ";
	for (int i = 0; i < b.numar_elemente; i++)
		out << b.venituri_anuale[i] << " ";
	return out;
}
int Banca::nr_banci = 0;

int main() {

	//testare cerinta 2
	cout << "Testare cerinta 2 \n\n";
	double v[] = { 1.5,1.6,3.2,4.7 };
	Banca test2("Olanda",v,4,TIP::COMERCIALA);
	cout << test2<<endl;
	/*
	string s = "";
	Banca test3(s, v, 4, TIP::NECUNOSCUTA);
	exemplu throw new exception pt string
	*/
	

	//testare cerinta 3
	cout << "Testare cerinta 3 \n\n";
	Banca test3(test2);
	Banca test3_2;
	test3_2 = test2;
	test3_2 = test2;
	cout << test3 << endl << test3_2<<endl;


	//testare cerinta 4 
	cout << "Testare cerinta 4 \n\n";
	Banca test_4;
	cout << test_4<<endl;
	
	//testare cerinta 5
	cout << "Testare cerinta 5 \n\n";
	cout << test2.getID() << " " << test2.getDenumire() << " " << test2.getTara() << " ";
	double* vec = test2.getvenituri();
	int nr = test2.getNumarElemente();
	for (int i = 0; i < nr; i++)
		cout << vec[i] << " ";
	cout << "\n";
	

	//testare cerinta 6
	cout << "Testare cerinta 6 \n\n";
	test3.setDenumire("ING BANK");
	test3.setNumarElem(5);
	test3.setTara("Romania");
	double v6[] = { 1.35, 1.46, 3.52, 7.82, 6.49 };
	test3.setvenituri(v6,5);
	cout << test3 << endl;

	//testare cerinta 7

	
	 cout << "Testare cerinta 7 \n\n";
	Banca test7;
	cin >> test7;
	cout << test7 << "\n";

	Banca test7_2;
	operator>>(cin, test7_2);
	operator<<(cout, test7_2);
	cout << '\n';
	
	

	//testare cerinta 8
	cout << "Testare cerinta 8 \n \n";
	Banca test8 = test3;
	cout << test8 << '\n';
	--test8;
	cout << test8 << '\n';
	test8(23);
	cout << test8 << '\n';
	
	
	cout << test8 + test3;
	//testare cerinta 9

	cout << "Testare cerinta 9 \n \n";
	Banca test9(test8);
	cout <<test9<<'\n';
   
	test9.AdaugaVenitLaSfarsit(3.33);
	cout << test9 << '\n';
	test9.stergeVenit(23.35);
	cout << test9 << '\n';

	cout << "Testare cerinta 10 \n \n";

	cout << "Venitul maxim este: " << test9.VenitMax() << " ,numar de aparitii: " << test9.VenitApMax()<<"\n";

	cout << test9 << "\n";
	test9.AdaugaVenitLa(60.43, 2);

	cout << test9;
	
}