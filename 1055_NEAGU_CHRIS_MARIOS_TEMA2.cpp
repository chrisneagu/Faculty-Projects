#include <iostream> //out << "DA" << endl : out << "NU" << endl; true sau false
#include <fstream>
#include <string>
using namespace std;

template<class A, class B> void afisareTemplate(A a, B b) {
	cout << a << " " << b << endl;
}

class ExceptieCustomAngajat : public exception {
public:
	const char* what()const throw() {
		return "Salariul angajatului trebuie sa fie >= 0\n";
	}
};

class Angajat {
protected:
	char* Nume;
	string Telefon;
	int Varsta;
	double Salariu;
public:
	virtual void marireSalariu() {
		Salariu += 200;
	}
	
	Angajat() {
		this->Nume = new char[strlen("Anonim") + 1];
		strcpy_s(this->Nume, strlen("Anonim") + 1,"Anonim");
		this->Telefon = "-";
		this->Varsta = 0;
		this->Salariu = 0.0;
	}

	Angajat(string telefon, int varsta, double salariu) {
		this->Telefon = telefon;
		this->Varsta = varsta;
		this->Salariu = salariu;
		this->Nume = new char[strlen("Anonim") + 1];
		strcpy_s(this->Nume, strlen("Anonim") + 1,"Anonim");
	}

	Angajat(const char* Nume, string telefon, int varsta, double salariu) {
		this->Telefon = telefon;
		this->Varsta = varsta;
		this->Salariu = salariu;
		this->Nume = new char[strlen(Nume) + 1];
		strcpy_s(this->Nume, strlen(Nume) + 1, Nume);
	}

	Angajat(const Angajat& copie) {
		this->Telefon = copie.Telefon;
		this->Varsta = copie.Varsta;
		this->Salariu = copie.Salariu;
		this->Nume = new char[strlen(copie.Nume) + 1];
		strcpy_s(this->Nume, strlen(copie.Nume) + 1, copie.Nume);
	}

	Angajat& operator=(const Angajat& copie) {
		if (this != &copie) {
			

			this->Telefon = copie.Telefon;
			this->Varsta = copie.Varsta;
			this->Salariu = copie.Salariu;
			

			if (this->Nume != nullptr)
				delete[] this->Nume;
			this->Nume = new char[strlen(copie.Nume) + 1];
			strcpy_s(this->Nume, strlen(copie.Nume) + 1, copie.Nume);
		}
		return *this;
	}

	~Angajat() {
		cout << "Destructor"<<endl;
		if (this->Nume != nullptr)
			delete[] this->Nume;
	}

	int getVarsta() {
		return this->Varsta;
	}

	double getSalariu() {
		return this->Salariu;
	}

	void setVarsta(int varsta) {
		if (varsta <= 0)
			throw new exception("Varsta<=0");
		this->Varsta = varsta;
	}
	
	void setSalariu(double salariu) {
		if (salariu <= 0)
			throw ExceptieCustomAngajat();
		this->Salariu = salariu;
	}

	bool operator==(Angajat& a) {
		if (this == &a) {
			return true;
		}

		return this->Telefon == a.Telefon &&
			this->Varsta == a.Varsta &&
			this->Salariu == a.Salariu &&
			strcmp(this->Nume, a.Nume) == 0;
	}

	friend ostream& operator<<(ostream& out, const Angajat& a) {

		out << "Nume " << a.Nume << " telefon " << a.Telefon << " varsta " << a.Varsta << " salariul " << a.Salariu;
		return out;

	}

	friend ofstream& operator<<(ofstream& out, const Angajat& a) {
		
		out << a.Nume << endl << a.Telefon <<endl << a.Varsta << endl << a.Salariu<<endl;
		return out;

	}

	friend istream& operator>>(istream& in, Angajat& a) {
		cout << "Nume: ";
		char aux[100];
		in >> aux;
		if (a.Nume != nullptr)
			delete[] a.Nume;
		a.Nume = new char[strlen(aux) + 1];
		
		strcpy_s(a.Nume, strlen(aux) + 1, aux);
		cout << "Telefon: ";
		in >> a.Telefon;
		cout << "Varsta: "; 
		in >> a.Varsta;
		cout << "Salariu: "; 
		in >> a.Salariu;
		return in;
	}


	friend ifstream& operator>>(ifstream& in, Angajat& a) {
		
		char aux[100];
		in.get(aux, 100);
		if (a.Nume != nullptr)
			delete[] a.Nume;
		a.Nume = new char[strlen(aux) + 1];
		strcpy_s(a.Nume, strlen(aux) + 1, aux);
		getline(in, a.Telefon);
		in >> a.Varsta;
		in >> a.Salariu;
		return in;
	}

};


class Frizer : public Angajat{
private:
	bool EsteCunoscut;
	int Tarif;
public:
	void marireSalariu() {
		Salariu += 500;
	}

	Frizer() : Angajat() {
		this->EsteCunoscut = false;
		this->Tarif = 0;
	}

	Frizer(
	const char* Nume,
	string Telefon,
	int Varsta,
	double Salariu,
	bool EsteCunoscut,
	int Tarif
	) : Angajat(Nume, Telefon, Varsta, Salariu) {
		this->EsteCunoscut = EsteCunoscut;
		this->Tarif = Tarif;
	}

	Frizer(const Frizer& f) : Angajat(f){
		this->EsteCunoscut = f.EsteCunoscut;
		this->Tarif = f.Tarif;
	}
	Frizer& operator=(const Frizer& f) {
		if (this != &f) {
			Angajat::operator=(f);
			this->EsteCunoscut = f.EsteCunoscut;
			this->Tarif = f.Tarif;
		}
		return *this;
	}



	friend ostream& operator<<(ostream& out, const Frizer& f) {

		out << (Angajat&)f;
		out << endl;
		(f.EsteCunoscut) ? out << true << endl : out << false << endl;
		out << "Tarif: " << f.Tarif<<endl;
		return out;

	}

	friend ofstream& operator<<(ofstream& out, const Frizer& f) {

		out << (Angajat&)f;
		(f.EsteCunoscut) ? out << true << endl : out << false << endl;
		out << f.Tarif << endl;;
		return out;

	}

	friend istream& operator>>(istream& in, Frizer& f) {
		in >> (Angajat&)f;
		cout << "Este cunoscut? ";
		in >> f.EsteCunoscut;
		cout << "Tarif: ";
		in >> f.Tarif;
		return in;
	}


	friend ifstream& operator>>(ifstream& in, Frizer& f) {
		in >> (Angajat&)f;
		in >> f.EsteCunoscut;
		in >> f.Tarif;
		return in;
	}
};

class Ministru : public Angajat{
private:
	bool EsteCorupt;
	bool ArePensieSpeciala;
public:
	void marireSalariu() {
		Salariu += 7000;
	}
	
	Ministru() : Angajat() {
		this->EsteCorupt = false;
		this->ArePensieSpeciala = false;
	}

	Ministru(
		const char* Nume,
		string Telefon,
		int Varsta,
		double Salariu,
		bool EsteCorupt,
		int ArePensieSpeciala
	) : Angajat(Nume, Telefon, Varsta, Salariu) {
		this->EsteCorupt = EsteCorupt;
		this->ArePensieSpeciala = ArePensieSpeciala;
	}

	Ministru(const Ministru& m) : Angajat(m) {
		this->EsteCorupt = m.EsteCorupt;
		this->ArePensieSpeciala = m.ArePensieSpeciala;
	}


	Ministru& operator=(const Ministru& m) {
		if (this != &m) {
			Angajat::operator=(m);
			this->EsteCorupt = m.EsteCorupt;
			this->ArePensieSpeciala = m.ArePensieSpeciala;
		}
		return *this;
	}


	friend ostream& operator<<(ostream& out, const Ministru& m) {

		out << (Angajat&)m << endl;
		(m.EsteCorupt) ? out << true << endl : out << false << endl;
		(m.ArePensieSpeciala) ? out << true << endl : out << false << endl;
		return out;

	}

	friend ofstream& operator<<(ofstream& out, const Ministru& m) {

		out << (Angajat&)m;
		(m.EsteCorupt) ? out << true << endl : out << false << endl;
		(m.ArePensieSpeciala) ? out << true << endl : out << false << endl;
		return out;

	}

	friend istream& operator>>(istream& in, Ministru& m) {
		in >> (Angajat&)m;
		cout << "Este corupt? ";
		in >> m.EsteCorupt;
		cout << "Are pensie speciala? ";
		in >> m.ArePensieSpeciala;
		return in;
	}


	friend ifstream& operator>>(ifstream& in, Ministru& m) {
		in >> (Angajat&)m;
		in >> m.EsteCorupt;
		in >> m.ArePensieSpeciala;
		return in;
	}
};

class ICompanie {
public:
	virtual void adaugaAngajat(Angajat& a) = 0;
	virtual void stergeAngajat(Angajat& a) = 0;
};

class Companie : public ICompanie {
private:
	string Denumire;
	Angajat **angajati;
	int NrAngajati;
public:
	Companie() {
		this->Denumire = "-";
		this->angajati = nullptr;
		this->NrAngajati = 0;
	}

	Companie(string Denumire, Angajat** angajati, int NrAngajati) {
		this->Denumire = Denumire;
		this->NrAngajati = NrAngajati;
		this->angajati = new Angajat * [NrAngajati];
		for (int i = 0; i < NrAngajati; i++)
		{
			this->angajati[i] = new Angajat;
			*this->angajati[i]=*angajati[i];
		}
	}

	Companie(const Companie& copie) {
		this->Denumire = copie.Denumire;
		this->NrAngajati = copie.NrAngajati;
		this->angajati = new Angajat * [copie.NrAngajati];
		for (int i = 0; i < copie.NrAngajati; i++)
		{
			this->angajati[i] = new Angajat;
			*(this->angajati[i]) = *copie.angajati[i];
		}
	}

	Companie& operator=(const Companie& copie) {
		if (this != &copie) {
			if (this->angajati != nullptr) {
				for (int i = 0; i < this->NrAngajati; i++)
				{
					delete this->angajati[i];
				}
				delete[] this->angajati;
			}
				
				
			this->Denumire = copie.Denumire;
			this->NrAngajati = copie.NrAngajati;
			this->angajati = new Angajat * [copie.NrAngajati];
			for (int i = 0; i < copie.NrAngajati; i++)
			{
				this->angajati[i] = new Angajat;
				*(this->angajati[i]) = *copie.angajati[i];
			}
		}
		return *this;
	}

	~Companie() {
		if (this->angajati != nullptr) {
			for (int i = 0; i < this->NrAngajati; i++)
			{
				delete this->angajati[i];
			}
			delete[] this->angajati;
		}
	}

	int getNrAngajati() {
		return this->NrAngajati;
	}

	string getDenumire() {
		return this->Denumire;
	}

	void setDenumire(string sir) {
		if (sir.empty())
			throw new exception("Sir este empty");
		this->Denumire = sir;
	}

	void setAngajati(Angajat** ang, int nr) {
		if (nr <= 0)
			throw new exception("Nr <= 0");
		if (ang == nullptr)
			throw new exception("ang este empty");

		if (this->angajati != nullptr) {
			for (int i = 0; i < this->NrAngajati; i++)
			{
				delete this->angajati[i];
			}
			delete[] this->angajati;
		}
		this->NrAngajati = nr;
		this->angajati = new Angajat * [nr];
		for (int i = 0; i < nr; i++)
		{
			this->angajati[i] = new Angajat;
			*(this->angajati[i]) = *ang[i];
		}
	}


	void adaugaAngajat(Angajat& a) {
		Angajat** aux = new Angajat* [this->NrAngajati + 1];
		for (int i = 0; i < this->NrAngajati; i++)
		{
			aux[i] = new Angajat;
			*aux[i] = *this->angajati[i];
		}
		aux[this->NrAngajati] = new Angajat;
		*aux[this->NrAngajati++] = a;

		if (this->angajati != nullptr) {
			for (int i = 0; i < this->NrAngajati-1; i++)
			{
				delete this->angajati[i];
			}
			delete[] this->angajati;
		}
		this->angajati = aux;
		
	}

	void stergeAngajat(Angajat& a) {
		int nr = 0;
		for (int i = 0; i < this->NrAngajati; i++) {
			if (*this->angajati[i] == a) {
				nr++;
			}
		}

		if (nr > 0) {
			for (int i = 0; i < this->NrAngajati; i++) {
				if (*this->angajati[i] == a) {
					for (int j = i; j < this->NrAngajati - 1; j++) {
						this->angajati[j] = angajati[j + 1];
					}
					this->NrAngajati--;
				}
			}

			Angajat** aux = new Angajat*[this->NrAngajati];
			for (int i = 0; i < this->NrAngajati; i++) {
				 aux[i] = new Angajat;
				*aux[i] = *this->angajati[i];
			}

			if (this->angajati != nullptr) {
				for (int i = 0; i < this->NrAngajati; i++)
				{
					delete this->angajati[i];
				}
				delete[] this->angajati;
			}
			this->angajati = aux;
		}
	}

	Angajat& operator[](int index){
		if (index >= 0 && index <= this->NrAngajati) {
			return *this->angajati[index];
		}
		else {
			throw new exception("Eroare op. []: index<0 sau index>NrAngajati");
		}
	}


	friend ostream& operator<<(ostream& out, const Companie& c);
	
	friend istream& operator>>(istream& in, Companie& c);

	friend ofstream& operator<<(ofstream& out, const Companie& c);

	friend ifstream& operator>>(ifstream& in, Companie& c);
	

};

ostream& operator<<(ostream& out, const Companie& c) {
	out << "Denumire " << c.Denumire << " cu " << c.NrAngajati << " angajati :" << endl;
	for (int i = 0; i < c.NrAngajati; i++) {
		out << *(c.angajati[i]) << endl;
	}
	return out;
}

istream& operator>>(istream& in, Companie& c) {
	cout << "Denumire: ";
	in >> c.Denumire;
	cout << "Numar angajati: ";
	in >> c.NrAngajati;
	if (c.angajati != nullptr) {
		for (int i = 0; i < c.NrAngajati; i++)
		{
			delete c.angajati[i];
		}
		delete[] c.angajati;
	}


	c.angajati = new Angajat * [c.NrAngajati];
	for (int i = 0; i < c.NrAngajati; i++) {
		c.angajati[i] = new Angajat;
		in >> *c.angajati[i];
	}
	return in;
}

ofstream& operator<<(ofstream& out, const Companie& c) {

	int dim = c.Denumire.size() + 1; //+1 - pt '\0' de la finalul unui sir de caractere
	out.write((char*)&dim, sizeof(dim));
	out.write((char*)&c.Denumire, dim);
	out.write((char*)&c.NrAngajati, sizeof(c.NrAngajati));
	for (int i = 0; i < c.NrAngajati; i++) {
		out.write((char*)&c.angajati[i], sizeof(Angajat));
	}
	return out;
}

ifstream& operator>>(ifstream& in, Companie& c) {
	//string
	int dim = 0;
	in.read((char*)&dim, sizeof(dim));

	char aux[100];
	in.read(aux, dim);
	c.Denumire = aux;

	in.read((char*)&c.NrAngajati, sizeof(c.NrAngajati));
	if (c.angajati != nullptr) {
		for (int i = 0; i < c.NrAngajati; i++)
		{
			delete c.angajati[i];
		}
		delete[] c.angajati;
	}

	c.angajati = new Angajat * [c.NrAngajati];
	for (int i = 0; i < c.NrAngajati; i++) {
		c.angajati[i] = new Angajat;
		in.read((char*)&c.angajati[i], sizeof(Angajat));
	}

	return in;

}

int main() {
	//testare cerinta 2
	Angajat tc2_1;
	cout << tc2_1 << endl;
	Angajat tc2_2("0762205027", 45, 4000);
	cout << tc2_2 << endl;
	tc2_1 = tc2_2;
	cout << tc2_1 << endl;
	Angajat tc2_3(tc2_2);
	cout << tc2_3 << endl;

	Frizer tc2_4;
	cout << tc2_4 << endl;
	Ministru tc2_5;
	cout << tc2_5 << endl;
	
	Frizer tc2_6("Neagu","0752252025",21,2500,1,200);
	cout << tc2_6 << endl;
	Ministru tc2_7("Bogdan","012392144",20,1300,0,0);
	cout << tc2_7 << endl;
	tc2_5 = tc2_7;
	tc2_4 = tc2_6;
	cout << tc2_4 << endl;
	cout << tc2_5 << endl;
	Ministru tc2_8(tc2_7);
	Frizer tc2_9(tc2_6);
	cout << tc2_8 << endl;
	cout << tc2_9 << endl;

	Companie necunoscuta;
	cout << necunoscuta << endl;
	Angajat** ang = new Angajat * [2];//{ &a, &b };
	for (int i = 0; i < 2; i++)
	{
		ang[i] = new Angajat;
	}
	*ang[0] = tc2_1;
	*ang[1] = tc2_2;
	Companie emag("Emag",ang,2);
	cout << emag << endl;
	Companie cemag(emag);
	cout << cemag << endl;
	necunoscuta = cemag;
	cout << necunoscuta;
	
	//testare cerinta 3
	cout << tc2_3.getSalariu() << " " << tc2_3.getVarsta() << endl;
	tc2_3.setSalariu(1200);
	tc2_3.setVarsta(18);
	cout << tc2_3.getSalariu() << " " << tc2_3.getVarsta() << endl;

	cout << emag.getDenumire() << " cu " << emag.getNrAngajati() << " angajati" << endl;
	Companie c;
	c.setDenumire("Flanco");
	c.setAngajati(ang,2);
	cout << c << endl;
	//testare cerinta 4
	try {
		tc2_3.setSalariu(-100);
	}
	catch (ExceptieCustomAngajat e) {
		cout << e.what() << endl;
	}
	//testare cerinta 5
	afisareTemplate(0, "sir de caractere");
	//testare cerinta 6
	Angajat t6("voicu", "02131945", 19, 2034);
	c.adaugaAngajat(t6);
	cout << c << endl;
	c.stergeAngajat(t6);
	cout << c << endl;

	//testare cerinta 7
	Angajat a7;
	ifstream angin("angajat.in");
	if (angin.is_open()) angin >> a7;
	angin.close();
	ofstream angout("angajat.out");
	angout << a7;
	angout.close();
	cin >> a7;
	cout << a7 << endl;

	Frizer f7;
	ifstream frizin("frizer.in");
	if (frizin.is_open()) frizin >> f7;
	frizin.close();
	ofstream frizout("frizer.out");
	frizout << f7;
	frizout.close();
	cin >> f7;
	cout << f7 << endl;

	Ministru m7;
	ifstream min("ministru.in");
	if(min.is_open()) min >> m7;
	min.close();
	ofstream mout("ministru.out");
	mout << m7;
	mout.close();

	cin >> m7;
	cout << m7 << endl;


	//testare cerinta 8
	cin >> emag;
	cout << emag<<endl;
	cout << c[1]<<endl;

	//testare cerinta 9
	cout << t6 << endl;
	cout << tc2_6 << endl;
	cout << tc2_7 << endl;
	t6.marireSalariu();
	tc2_6.marireSalariu();
	tc2_7.marireSalariu();
	cout << t6 << endl;
	cout << tc2_6 << endl;
	cout << tc2_7 << endl;

	//testare cerinta 10
	ofstream fout("comp.bin", ios::in | ios::binary);
	fout << emag;
	fout.close();
	ifstream fin("comp.bin", ios::in | ios::binary);
	if (fin.is_open()) {
		fin >> c;
		cout << c;
		fin.close();
	}
	else {
		cout << "Fisierul comp.bin nu poate fi deschis pentru citire.\n";
	}



	for (int i = 0; i < 2; i++)
	{
		delete ang[i];
	}
	delete[] ang;
}