#include <iostream>
#include <string>
#include <vector>
#include <fstream>
using namespace std;

//cerinta 6
class ExceptieCustomInstrument : public exception {
public:
	// virtual char const* what() const
	const char* what()const throw() {
		return "Producator este nullptr\n";
	}
};

class ExceptieCustomTrianglu : public exception {
public:
	// virtual char const* what() const
	const char* what()const throw() {
		return "Culoare este empty\n";
	}
};

//cerinta 1
class IInstrument {
public:
	void virtual plateste_asigurarea() = 0;
};

class Instrument : public IInstrument{
	const int id;
	char* producator; //cerinta 2
	static int nr;
	double* frecvente_note; //cerinta 2
	int nr_note;
public:

	Instrument(const char* producator, double* frecvente_note, int nr_note) : id(nr++) {
		if (producator == nullptr)
			throw ExceptieCustomInstrument();
		if(frecvente_note == nullptr)
			throw new exception("Frecvente note este nullptr");
		if (nr_note <= 0)
			throw new exception("Nr note este <= 0");
		this->producator = new char[strlen(producator) + 1];
		strcpy_s(this->producator, strlen(producator) + 1, producator);
		this->nr_note = nr_note;
		this->frecvente_note = new double[nr_note];
		for (int i = 0; i < nr_note; i++) {
			this->frecvente_note[i] = frecvente_note[i];
		}
	}

	Instrument() : id(nr++) {
		this->producator = new char[strlen("Anonim") + 1];
		strcpy_s(this->producator, strlen("Anonim") + 1, "Anonim");
		this->frecvente_note = nullptr;
		this->nr_note = 0;
	}

	Instrument(double* frecvente_note, int nr_note) : id(nr++) {
		if (frecvente_note == nullptr)
			throw new exception("Frecvente note este nullptr");
		if (nr_note <= 0)
			throw new exception("Nr note este <= 0");
		this->nr_note = nr_note;
		this->frecvente_note = new double[nr_note];
		for (int i = 0; i < nr_note; i++) {
			this->frecvente_note[i] = frecvente_note[i];
		}
		this->producator = new char[strlen("Anonim") + 1];
		strcpy_s(this->producator, strlen("Anonim") + 1, "Anonim");
	}

	Instrument(const Instrument& ins) : id(nr++){
		this->producator = new char[strlen(ins.producator) + 1];
		strcpy_s(this->producator, strlen(ins.producator) + 1, ins.producator);
		this->nr_note = ins.nr_note;
		this->frecvente_note = new double[ins.nr_note];
		for (int i = 0; i < ins.nr_note; i++) {
			this->frecvente_note[i] = ins.frecvente_note[i];
		}
	}

	Instrument& operator=(const Instrument& ins) {
		if (this != &ins) {
			this->producator = new char[strlen(ins.producator) + 1];
			strcpy_s(this->producator, strlen(ins.producator) + 1, ins.producator);
			this->nr_note = ins.nr_note;
			this->frecvente_note = new double[ins.nr_note];
			for (int i = 0; i < ins.nr_note; i++) {
				this->frecvente_note[i] = ins.frecvente_note[i];
			}
		}
		return *this;
	}

	~Instrument() {
		if (this->frecvente_note != nullptr)
			delete[] this->frecvente_note;
		if (this->producator != nullptr)
			delete[] this->producator;
	}

	//cerinta 4
	const Instrument& operator--() { //pre
		for (int i = 0; i < nr_note; i++)
			--frecvente_note[i];
		return *this;
	}

	const Instrument operator--(int) { //post
		Instrument aux(*this);
		for (int i = 0; i < nr_note; i++)
			aux.frecvente_note[i]--;
		return aux;
	}


	const Instrument& operator++() {
		for (int i = 0; i < nr_note; i++)
			++frecvente_note[i];
		return *this;
	}

	const Instrument operator++(int) {
		Instrument aux(*this);
		for (int i = 0; i < nr_note; i++)
			aux.frecvente_note[i]++;
		return aux;
	}

	Instrument& operator+(double x) {
		
		for (int i = 0; i < nr_note; i++)
			frecvente_note[i]+=x;
		return *this;
	}

	Instrument& operator-(double x) {
		for (int i = 0; i < nr_note; i++)
			frecvente_note[i] -= x;
		return *this;
	}

	friend ostream& operator<<(ostream& out, const Instrument& ins) {
		out << ins.producator<<' '<< ins.nr_note << endl;
		for (int i = 0; i < ins.nr_note; i++)
			out << ins.frecvente_note[i] << ' ';
		out << endl;
		return out;
	}

	friend istream& operator>>(istream& in, Instrument& ins) {
		in >> ins.producator;
		in >> ins.nr_note;
		for (int i = 0; i < ins.nr_note; i++)
			in >> ins.frecvente_note[i];
		return in;
	}


	friend ofstream& operator<<(ofstream& out, const Instrument& ins) {
		int dim = strlen(ins.producator) + 1;
		out.write((char*)&dim, sizeof(int));
		out.write(ins.producator, dim);
		out.write((char*)&ins.nr_note, sizeof(int));
		for (int i = 0; i < ins.nr_note; i++)
			out.write((char*)&ins.frecvente_note[i], sizeof(double));
		return out;
	}

	friend ifstream& operator>>(ifstream& in, Instrument& ins) {
		int dim = 0;
		in.read((char*)&dim, sizeof(int));
		if (ins.producator != nullptr)
			delete[] ins.producator;
		ins.producator = new char[dim];
		char aux[100];
		in.read(aux, dim);
		strcpy_s(ins.producator, dim, aux);
		in.read((char*)&ins.nr_note, sizeof(int));
		if (ins.frecvente_note != nullptr)
			delete[] ins.frecvente_note;
		ins.frecvente_note = new double[ins.nr_note];
		for (int i = 0; i < ins.nr_note; i++)
			in.read((char*)&ins.frecvente_note[i], sizeof(double));
		return in;
	}

	Instrument& operator+=(double x) {
		for (int i = 0; i < nr_note; i++)
			frecvente_note[i]+=x;
		return *this;
	}

	int operator!() {
		return -id;
	}

	bool operator==(Instrument& ins) {
		if (this == &ins) {
			return true;
		}

		bool normalFields = strcmp(this->producator, ins.producator) == 0 &&
			this->nr_note == ins.nr_note;
		if (normalFields == true) {
			for (int i = 0; i < ins.nr_note; i++) {
				if (this->frecvente_note[i] != ins.frecvente_note[i]) {
					return false;
				}
			}
			return true;
		}
		return false;
	}


	double& operator[](int index) {
		if (index >= 0 && index <= nr_note) {
			return frecvente_note[index];
		}
		else {
			throw new exception("Eroare op. []: index<0 sau index>nrNote");
		}
	}

	void operator()(double valoare) {
		for (int i = 0; i < nr_note; i++) 
			frecvente_note[i] += valoare;
	}

	operator char* () {
		return this->producator;
	}

	void virtual canta() {
		cout << "Sunet basic\n";
	}
	
	void plateste_asigurarea() {
		cout << "S-a platit asigurarea de 100 de lei!\n";
	}
};

class Toba : public Instrument, public IInstrument {
	bool are_bete;
public:

	Toba(const char* producator, double* frecvente_note, int nr_note, bool are_bete) : Instrument(producator, frecvente_note, nr_note) {
		this->are_bete = are_bete;
	}

	Toba() : Instrument() {
		this->are_bete = false;
	}

	Toba(double* frecvente_note, int nr_note, bool are_bete) : Instrument(frecvente_note, nr_note) {
		this->are_bete = are_bete;
	}

	Toba(const Toba& t) : Instrument(t){
		this->are_bete = t.are_bete;
	}

	Toba& operator=(const Toba& t){
		if (this != &t) {
			Instrument::operator=(t);
			this->are_bete = t.are_bete;
		}
		return *this;
	}

	friend ostream& operator<<(ostream& out, const Toba& t) {
		out << (Instrument&)t << endl;
		(t.are_bete) ? out << true << endl : out << false << endl;
		return out;
	}

	friend istream& operator>>(istream& in, Toba& t) {
		in >> (Instrument&)t;
		in >> t.are_bete;
		return in;
	}


	friend ofstream& operator<<(ofstream& out, const Toba& t) {
		out << (Instrument&)t << endl;
		out.write((char*)&t.are_bete, sizeof(bool));
		return out;
	}

	friend ifstream& operator>>(ifstream& in, Toba& t) {
		in >> (Instrument&)t;
		in.read((char*)&t.are_bete, sizeof(bool));
		return in;
	}

	void canta() {
		cout << "Boom-Boom\n";
	}
	void plateste_asigurarea() {
		cout << "S-a platit asigurarea de 300 de lei!\n";
	}
};

class Trianglu : public Instrument, public IInstrument {
	string culoare;
public:

	Trianglu(const char* producator, double* frecvente_note, int nr_note, string culoare) : Instrument(producator, frecvente_note, nr_note) {
		if (culoare.empty())
			throw ExceptieCustomTrianglu();
		this->culoare = culoare;
	}

	Trianglu() : Instrument() {
		this->culoare = "";
	}

	Trianglu(double* frecvente_note, int nr_note, string culoare) : Instrument(frecvente_note, nr_note) {
		if (culoare.empty())
			throw new exception("Culoare este empty");
		this->culoare = culoare;
	}

	Trianglu(const Trianglu& t) : Instrument(t) {
		this->culoare=t.culoare;
	}

	Trianglu& operator=(const Trianglu& t) {
		if (this != &t) {
			Instrument::operator=(t);
			this->culoare = t.culoare;
		}
		return *this;
	}

	friend ostream& operator<<(ostream& out, const Trianglu& t) {
		out << (Instrument&)t << endl;
		out << t.culoare;
		return out;
	}

	friend istream& operator>>(istream& in, Trianglu& t) {
		in >> (Instrument&)t;
		in >> t.culoare;
		return in;
	}

	friend ofstream& operator<<(ofstream& out, const Trianglu& t) {
		out << (Instrument&)t << endl;
		int dim = t.culoare.size() + 1;
		out.write((char*)&dim, sizeof(int));
		out.write(t.culoare.c_str(), dim);
		return out;
	}

	friend ifstream& operator>>(ifstream& in, Trianglu& t) {
		in >> (Instrument&)t;
		int dim = 0;
		in.read((char*)&dim, sizeof(int));
		char aux[100];
		in.read(aux, dim);
		t.culoare = aux;
		return in;
	}

	void canta() {
		cout << "Ding-ding\n";
	}
	void plateste_asigurarea() {
		cout << "S-a platit asigurarea de 50 de lei!\n";
	}
};

//cerinta 5
class Trupa {
	string denumire_trupa;
	int nr;
	Instrument* instrumental;
public:
	//cerinta 7 

	Trupa(string denumire_trupa, int nr, Instrument* instrumental) {
		this->denumire_trupa = denumire_trupa;
		this->nr = nr;
		this-> instrumental = new Instrument[nr];
		for (int i = 0; i < nr; i++)
			this->instrumental[i] = instrumental[i];
	}

	friend ofstream& operator<<(ofstream& out, const Trupa& t) {
		
		int dim = t.denumire_trupa.size() + 1;
		out.write((char*)&dim, sizeof(int));
		out.write(t.denumire_trupa.c_str(), dim);
		out.write((char*)&t.nr, sizeof(int));
		for (int i = 0; i < t.nr; i++)
			out << t.instrumental[i];
		return out;
	}

	friend ifstream& operator>>(ifstream& in, Trupa& t) {
		int dim = 0;
		in.read((char*)&dim, sizeof(int));
		char aux[100];
		in.read(aux, dim);
		t.denumire_trupa = aux;
		in.read((char*)&t.nr, sizeof(int));
		if (t.instrumental != nullptr)
			delete[] t.instrumental;
		t.instrumental = new Instrument[t.nr];
		Instrument ins;
		for (int i = 0; i < t.nr; i++) {
			in >> ins;
			t.instrumental[i]=ins;
		}
		
		return in;
	}


	friend ostream& operator<<(ostream& out, const Trupa& t) {

		out << t.denumire_trupa <<' '<< t.nr<<endl;
		for (int i = 0; i < t.nr; i++)
			out << t.instrumental[i]<<endl;
		return out;
	}

	~Trupa() {
		if (this->instrumental != nullptr)
			delete[] this->instrumental;
	}
};

//cerinta 8 
class Formatie {
	string denumire_trupa;
	vector <Instrument> instrumental;
public:
	//cerinta 7 
	Formatie(string denumire_trupa, vector<Instrument> instrumental) {
		this->denumire_trupa = denumire_trupa;
		this->instrumental = instrumental;
	}

	friend ostream& operator<<(ostream& out, const Formatie& f) {
		
		out << f.denumire_trupa << endl;
		for (int i = 0; i < f.instrumental.size(); i++)
			out << f.instrumental[i];
		return out;
	}


	friend ofstream& operator<<(ofstream& out, const Formatie& f) {
		
		int dim = f.denumire_trupa.size() + 1;
		out.write((char*)&dim, sizeof(int));
		out.write(f.denumire_trupa.c_str(), dim);
		dim = f.instrumental.size();
		out.write((char*)&dim, sizeof(int));
		for (int i = 0; i < dim; i++)
			out << f.instrumental[i];
		return out;
	}

	friend ifstream& operator>>(ifstream& in, Formatie& f) {
		int dim = 0;
		in.read((char*)&dim, sizeof(int));
		char aux[100];
		in.read(aux, dim);
		f.denumire_trupa = aux;
		in.read((char*)&dim, sizeof(int));
		if (!f.instrumental.empty())
			f.instrumental.clear();
		Instrument ins;
		for (int i = 0; i < dim; i++) {
			in >> ins;
			f.instrumental.push_back(ins);
		}
			
		return in;
	}
};




int Instrument::nr = 0;

int main() {
	//testare cerinta 1
	cout << "===testare cerintele 1-3===" << endl << endl;
	double frecvente_note[] = { 3.2,4.5,6.7 };
	double frecvente_note2[] = { 2.42,46.8,67.3 };
	double frecvente_note3[] = { 32.12,34.25,6.71 };
	Instrument ins("Anonim", frecvente_note, 3);
	cout << ins << endl;
	Instrument ins_default;
	cout << ins_default << endl;
	Instrument ins_fara(frecvente_note, 3);
	cout << ins_fara << endl;
	Instrument ins_copie(ins_default);
	cout << ins_copie << endl;
	ins_default = ins_fara;
	cout << ins_default << endl;


	Toba toba("Anonim", frecvente_note, 3,true);
	cout << toba << endl;
	Toba toba_default;
	cout << toba_default << endl;
	Toba toba_fara(frecvente_note, 3,true);
	cout <<	toba_fara << endl;
	Toba toba_copie(toba_default);
	cout << toba_copie << endl;
	toba_default = toba_fara;
	cout << toba_default << endl;


	Trianglu trianglu("Anonim", frecvente_note, 3, "aurie");
	cout << trianglu << endl;
	Trianglu trianglu_default;
	cout << trianglu_default << endl;
	Trianglu trianglu_fara(frecvente_note, 3, "aurie");
	cout << trianglu_fara << endl;
	Trianglu trianglu_copie(trianglu_default);
	cout << trianglu_copie << endl;
	trianglu_default = trianglu_fara;
	cout << trianglu_default << endl;

	Instrument ins2("Yamaha", frecvente_note2, 3);
	Instrument ins3("Harley", frecvente_note3, 3);
	Toba t("Anonim", frecvente_note, 3, true);
	Trianglu tg("Anonim", frecvente_note, 3, "aurie");
	

	//testare cerinta 4
	cout << "===testare cerinta 4===" << endl << endl;
	cout << ins2 << endl;
	ins2 = ins3;
	cout << "operator =" << endl;
	cout << ins2 << endl;
	cout << "operator -- post incrementare" << endl;
	cout << ins2-- << endl;
	cout << ins2 << endl;
	cout << "operator -- pre incrementare" << endl;
	cout << --ins2 << endl;
	cout << ins2 << endl;
	cout << "operator ++ post incrementare" << endl;
	cout << ins2++ << endl;
	cout << ins2 << endl;
	cout << "operator ++ pre incrementare" << endl;
	cout << ++ins2 << endl;
	cout << ins2 << endl;
	cout << "operator +=" << endl;
	ins2 += 3.2;
	cout << ins2 << endl;
	cout << "operator !" << endl;
	cout << !ins2 << endl;
	cout << "operator==" << endl;
	cout << (ins2 == ins3)<<endl;
	cout << "operator[]" << endl;
	cout << ins2[0] << endl;
	cout << "operator()" << endl;
	ins2(10.24);
	cout << ins2 << endl;
	cout << "operator char* cast" << endl;
	cout << (char*)ins2<<endl;
	//cin >> ins2;
	cout << ins2 << endl;
	//testare cerinta 5
	cout << "===testare cerinta 5===" << endl << endl;
	Instrument* ins7 = new Instrument[3]{ ins,ins2,ins3 };
	Trupa tr7("Beatles", 3, ins7);
	cout << tr7 << endl;
	//testare cerinta 6
	cout << "===testare cerinta 6===" << endl << endl;
	try{
		Instrument ins6(nullptr,frecvente_note,3);

	}
	catch (ExceptieCustomInstrument e) {
		cout << e.what();
	}
	try {
		Trianglu t("Anonim", frecvente_note, 3, "");
	}
	catch (ExceptieCustomTrianglu e) {
		cout << e.what();
	}
	//testare cerinta 7
	cout << "\n\n";
	cout << "===fisiere binare(7)===" << endl << endl;
	
	cout << tr7 << endl;
	ofstream fisBinarOut("trupa.bin", ios::out | ios::binary | ios::app);
	if (fisBinarOut.is_open()) {
		fisBinarOut << tr7;
		fisBinarOut.close();
	}
	else {
		cout << "Fisierul trupa.bin nu poate fi deschis pentru scriere.\n";
	}
	ifstream fisBinarIn("trupa.bin", ios::in | ios::binary);
	if (fisBinarIn.is_open()) {
		fisBinarIn >> tr7;
		fisBinarIn.close();
	}
	else {
		cout << "Fisierul trupa.bin nu poate fi deschis pentru citire.\n";
	}
	cout << tr7 << endl;
	
	//testare cerinta 8
	cout << "\n\n";
	cout << "===fisiere binare vector(8)===" << endl << endl;
	vector<Instrument> vec;
	Instrument t8(ins);
	vec.push_back(ins);
	vec.push_back(t8);
	Formatie f("Avicii",vec);
	
	cout << f<<endl;
	ofstream fisBinarOut2("formatie.bin", ios::out | ios::binary|ios::app);
	if(fisBinarOut2.is_open()) {
		fisBinarOut2 << f;
		fisBinarOut2.close();
	}
	else {
		cout << "Fisierul formatie.bin nu poate fi deschis pentru scriere.\n";
	}
	ifstream fisBinarIn2("formatie.bin", ios::in | ios::binary);
	if (fisBinarIn2.is_open()) {
		fisBinarIn2 >> f;
		fisBinarIn2.close();
	}
	else {
		cout << "Fisierul formatie.bin nu poate fi deschis pentru citire.\n";
	}

	cout << f<<endl;
	//testare cerinta 9
	Instrument* i = &t;
	cout << "\n\n";
	cout << "===testare cerinta 9===" << endl << endl;
	cout << "\n\n";
	cout << "===early-binding===" << endl << endl;

	i->canta();
	i->plateste_asigurarea();

	t.canta();
	t.plateste_asigurarea();

	tg.canta();
	tg.plateste_asigurarea();
	
	cout << "\n\n";
	cout << "===late-binding===" << endl << endl;

	Instrument* ip = &t;
	ip->canta();
	ip->plateste_asigurarea();

	ip = &tg;
	ip->canta();
	ip->plateste_asigurarea();


	//testare cerinta 10
	cout << "\n\n";
	cout << "===polimorfism(10)===" << endl << endl;
	Instrument** vectorDeInstrumente = new Instrument * [3]{ &ins,&t, &tg};
	for (int i = 0; i < 3; i++) {
		vectorDeInstrumente[i]->canta();
		vectorDeInstrumente[i]->plateste_asigurarea();
	}
	delete[] ins7;
}