using System;
using System.Collections;
using System.Collections.Generic;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 3");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
    case 2: { task2();  break;}
    case 3: { task3();  break;}
  }
      
    }



static void task1()
{
    Console.WriteLine("\nTask1");
    Console.Write("Numner of triangle: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string c ="Blue";

    for(int f = 0;f<n;f++)
    {Console.Write("\n\n  Triangle "+(f+1));
      int [] a=new int[2];

    Console.Write("\nSides: ");
    for(int i = 0;i<a.Length;i++)
    {
      a[i]= Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Color: ");
     c=Convert.ToString(Console.ReadLine());

    ITriangle first = new ITriangle ();
    first.col(c);
    int p =first.perimeter(a[0],a[1]);
    Console.Write("\nPerimeter: "+p);
    double s =first.area(a[0],a[1],p);
    Console.Write("\nS: "+s);
    bool t =first.correct(a[0],a[1]);
    Console.Write("\nCorrect: "+t);


    Console.Write("\nChange sides: ");
    int [] k=new int[2];
    for(int i = 0;i<k.Length;i++)
    {
      k[i]= Convert.ToInt32(Console.ReadLine());
    }
    int [] b={k[0],k[1]};
    first.Sidegr=b;
    b=first.Sidegr;

    Console.Write("\nSides: ");
    for(int i = 0;i<b.Length;i++)
    {
      Console.Write(+b[i]+" ");
    }
    Console.Write("\nColor: "+ first.Colorgr);
    
    Console.Write("\nIndex: ");
    int ind = Convert.ToInt32(Console.ReadLine());   
    string ch=first[ind];
    if(ch=="0") Console.Write("\nError ");
    Console.Write("So: "+ ch);

    Console.Write("\n++: "+ (first++).show());
    Console.Write("\n--: "+ (first--).show());

    Console.Write("\nBool: "+ (bool)first);
    Console.Write("\n*: "+ (first*2).show());
    
    string str= (string)first;
    Console.Write("\nStr: "+ str);
    ITriangle second = (ITriangle)str;
    Console.Write("\nITriangle: "+ second.show());
    
    } 
}

static void task2()
{
    Console.WriteLine("\nTask2");
    VectorDecimal v = new VectorDecimal(5,6);
    VectorDecimal v1 = new VectorDecimal(5,3);
    Console.WriteLine("\nV: ");
    v.sh();
    Console.WriteLine("\nV1: ");
    v1.sh();

    Console.WriteLine("\nInp: ");
    v.arinp();
    Console.WriteLine("\nInp1: ");
    v.arinp();
    Console.WriteLine("\nOut: ");
    v.arout();
    Console.WriteLine("\nOut1: ");
    v.arout();
    Console.WriteLine("\nElem 1: ");
    v.elem(1);
    v.sh();
    int n = v.Arlen;
    Console.WriteLine("\nArlen: "+n);
    Console.WriteLine("\nInput code error: ");
    int e = Convert.ToInt32(Console.ReadLine());
    v.Er=e;
    Console.WriteLine("\nCode error: "+v.Er);
    Console.WriteLine("\nInput index: ");
    int ind = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Element: "+v[ind]);
    v++;
    v.sh();
    v--;
    v.sh();
    Console.WriteLine("\nSize=0 || a[i]=0: "+(bool)v);
    Console.WriteLine("\nSize!=0: "+!v);
    Console.WriteLine("\n ~ : "+~v);
    VectorDecimal v3 = v+v1;
    Console.WriteLine("\nV + V1: ");
    v3.arout();
    v3 = v+5;
    Console.WriteLine("\nV + 5: ");
    v3.arout();
    v3 = v-v1;
    Console.WriteLine("\nV - V1: ");
    v3.arout();
    v3 = v-5;
    Console.WriteLine("\nV - 5: ");
    v3.arout();
    v3 = v*v1;
    Console.WriteLine("\nV * V1: ");
    v3.arout();
    v3 = v*5;
    Console.WriteLine("\nV * 5: ");
    v3.arout();
    v3 = v/v1;
    Console.WriteLine("\nV / V1: ");
    v3.arout();
    v3 = v/5;
    Console.WriteLine("\nV / 5: ");
    v3.arout();
    v3 = v%v1;
    Console.WriteLine("\nV % V1: ");
    v3.arout();
    v3 = v%5;
    Console.WriteLine("\nV % 5: ");
    v3.arout();
    v3 = v|v1;
    Console.WriteLine("\nV | V1: ");
    v3.arout();
    v3 = v|5;
    Console.WriteLine("\nV | 5: ");
    v3.arout();
    v3 = v^v1;
    Console.WriteLine("\nV ^ V1: ");
    v3.arout();
    v3 = v^5;
    Console.WriteLine("\nV ^ 5: ");
    v3.arout();
    v3 = v<<5;

    Console.WriteLine("\nV << 5: ");
    v3.arout();

    Console.WriteLine("\nV == V1: "+(v==v1));
    Console.WriteLine("\nV != V1: "+(v!=v1));
    Console.WriteLine("\nV > V1: "+(v>v1));
    Console.WriteLine("\nV >= V1: "+(v>=v1));
    Console.WriteLine("\nV < V1: "+(v<v1));
    Console.WriteLine("\nV <= V1: "+(v<=v1));

}
 
static void task3()
{
    Console.WriteLine("\nTask2");
    DemicalMatrix v = new DemicalMatrix(5,6,4);
    DemicalMatrix v1 = new DemicalMatrix(5,3,6);
    Console.WriteLine("\nV: ");
    v.sh();
    Console.WriteLine("\nV1: ");
    v1.sh();

    Console.WriteLine("\nInp: ");
    v.arinp();
    Console.WriteLine("\nInp1: ");
    v.arinp();
    Console.WriteLine("\nOut: ");
    v.arout();
    Console.WriteLine("\nOut1: ");
    v.arout();
    Console.WriteLine("\nElem 1: ");
    v.elem(1);
    v.sh();
    int n = v.Arlen;
    Console.WriteLine("\nArlen: "+n);
    Console.WriteLine("\nInput code error: ");
    int e = Convert.ToInt32(Console.ReadLine());
    v.Er=e;
    Console.WriteLine("\nCode error: "+v.Er);
    Console.WriteLine("\nInput index: ");
    int ind = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Element: "+v[ind]);
    v++;
    v.sh();
    v--;
    v.sh();
    Console.WriteLine("\nSize=0 || a[i]=0: "+(bool)v);
    Console.WriteLine("\nSize!=0: "+!v);
    Console.WriteLine("\n ~ : "+~v);
    DemicalMatrix v3 = v+v1;
    Console.WriteLine("\nV + V1: ");
    v3.arout();
    v3 = v+5;
    Console.WriteLine("\nV + 5: ");
    v3.arout();
    v3 = v-v1;
    Console.WriteLine("\nV - V1: ");
    v3.arout();
    v3 = v-5;
    Console.WriteLine("\nV - 5: ");
    v3.arout();
    v3 = v*v1;
    Console.WriteLine("\nV * V1: ");
    v3.arout();
    v3 = v*5;
    Console.WriteLine("\nV * 5: ");
    v3.arout();
    v3 = v/v1;
    Console.WriteLine("\nV / V1: ");
    v3.arout();
    v3 = v/5;
    Console.WriteLine("\nV / 5: ");
    v3.arout();
    v3 = v%v1;
    Console.WriteLine("\nV % V1: ");
    v3.arout();
    v3 = v%5;
    Console.WriteLine("\nV % 5: ");
    v3.arout();
    v3 = v|v1;
    Console.WriteLine("\nV | V1: ");
    v3.arout();
    v3 = v|5;
    Console.WriteLine("\nV | 5: ");
    v3.arout();
    v3 = v^v1;
    Console.WriteLine("\nV ^ V1: ");
    v3.arout();
    v3 = v^5;
    Console.WriteLine("\nV ^ 5: ");
    v3.arout();
    v3 = v<<5;

    Console.WriteLine("\nV << 5: ");
    v3.arout();

    Console.WriteLine("\nV == V1: "+(v==v1));
    Console.WriteLine("\nV != V1: "+(v!=v1));
    Console.WriteLine("\nV > V1: "+(v>v1));
    Console.WriteLine("\nV >= V1: "+(v>=v1));
    Console.WriteLine("\nV < V1: "+(v<v1));
    Console.WriteLine("\nV <= V1: "+(v<=v1));

}
 
  
  }
class ITriangle{
  protected int a, b;
  protected string c;

  public int [] sides(int sa, int sb){
    int [] a = {sa,sb};
    return a;   
  }
  public int perimeter(int sa, int sb){
    int p=sa+2*sb;
    return p;   
  }
  public double area (int sa, int sb, int p1){
    int p=p1/2;
    double s= Math.Sqrt(p*(p1-sa)*(p1-sb)*(p1-sb));
    return s;   
  }
  public bool correct (int sa, int sb){
    if(sa==sb) return true; 
    else return false;
  }

  public void col(string color){
    this.c=color;
  }
  public string show(){
    return "A: "+a+" \n    B: "+b+"  \n    C: "+c;
  }
  public int[] Sidegr{
    get{
      int [] k= {this.a,this.b};
      return k;
    }

    set{
      a=value[0];
      b=value[1];
    }
  }
  public string Colorgr{
    get{
      string s=this.c;
      return s;
    }
  }

  public string this[int ind]{
    get{
      if(ind==0) return $"{a}";
      else if(ind==1) return $"{b}";
      else if(ind==2) return c;
      else return "0";
    }
    
  }

  public static ITriangle operator++ (ITriangle t) {
         t.a += 1;
         t.b += 1;
         return t;
      }

  public static ITriangle operator-- (ITriangle t) {
         t.a -= 1;
         t.b -= 1;
         return t;
  }

  public static explicit operator bool(ITriangle t) {
    return (t.a != 0)&&(t.b != 0);
  }
 
  
  public static ITriangle operator* (ITriangle t,int scal) {
    ITriangle k = new ITriangle();
    k.a = t.a*scal;
    k.b = t.b*scal;
    return k;
  }

  public static explicit operator string(ITriangle t) {
    return $"{t.a}, {t.b}, {t.c}";
  }

  public static explicit operator ITriangle(string str) {
    ITriangle t = new ITriangle();
    string[] s = str.Split(',');
    t.a = int.Parse(s[0].Trim('(', ')'));
    t.b = int.Parse(s[1]);
    t.c = s[2];
    return t;
  }


}

class VectorDecimal{
  protected decimal [] ArrayDecimal; 
  protected uint num; 
  protected int codeError;
  protected static uint num_vec;

  public VectorDecimal(){
    ArrayDecimal =new decimal[1];
    this.num = 1;
    ArrayDecimal[0]=0;
  }
  public VectorDecimal(uint s){
    ArrayDecimal =new decimal[s];
    this.num = s;
    for (int i = 0; i < s; i++) {
    ArrayDecimal[i]=0;
    }
  }
  public VectorDecimal(uint s, int k){
    ArrayDecimal =new decimal[s];
    this.num = s;
    for (int i = 0; i < s; i++) {
    ArrayDecimal[i]=k;
    }
  }
  public void sh(){
    Console.WriteLine("Ar: ");
    for(int i =0;i<ArrayDecimal.Length;i++){
    Console.WriteLine(ArrayDecimal[i]+" ");}
    Console.WriteLine("Num: "+num);
    Console.WriteLine("CodeError: "+codeError);
    Console.WriteLine("Num_v: "+num_vec);
  }
  ~VectorDecimal(){
    Console.WriteLine("Destructor");
  }
  public void arinp(){
      Console.WriteLine("Number of element: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for(int i =0;i<n;i++){
      ArrayDecimal[i]=Convert.ToDecimal(Console.ReadLine());
  }}
  public void arout(){

    for (int i = 0; i < ArrayDecimal.Length; i++) {
        Console.Write(ArrayDecimal[i]+" ");
    }
  }
  public decimal[] elem(decimal k){
    for(int i =0;i<ArrayDecimal.Length;i++){
    ArrayDecimal [i] = k;
    }
    return ArrayDecimal;
  }
   public int Arlen{
    get{
      return ArrayDecimal.Length;
    }
  }  
  public int Er{
    get{
      return codeError;
    }
    set{
      codeError = value;
    }
  }  

  public decimal this[int ind]{
    get{
      if(ind<0||ind>=ArrayDecimal.Length) {
        this.codeError=1;
        return codeError;}
      return ArrayDecimal [ind];
    }
    
  }

  public static VectorDecimal operator++ (VectorDecimal t) {
    for(int i =0;i<t.ArrayDecimal.Length;i++){
    t.ArrayDecimal [i] += 1;
    }
    return t;
  }

  public static VectorDecimal operator-- (VectorDecimal t) {
    for(int i =0;i<t.ArrayDecimal.Length;i++){
    t.ArrayDecimal [i] -= 1;
    }
    return t;
  }

  public static explicit operator bool(VectorDecimal t) {
    int k=0;
    for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] ==0) k++;
    }
    return (t.num != 0)||(k == 0);
  }

  public static bool operator !(VectorDecimal t) {
    return (t.num != 0);
  }
 
  public static VectorDecimal operator ~(VectorDecimal t) {
    for (int i = 0; i < t.ArrayDecimal.Length; i++) {
      t.ArrayDecimal[i] = (int)(t.ArrayDecimal[i]);
    }
    return t;
  }

  public static VectorDecimal operator +(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] += c.ArrayDecimal[i];
      return t;
    }
    return t;
  }

  public static VectorDecimal operator +(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] += c;
    return t;
  }

  public static VectorDecimal operator -(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] -= c.ArrayDecimal[i];
      return t;
    }
    return t;
  }

  public static VectorDecimal operator -(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] -= c;
    return t;
  }

  public static VectorDecimal operator *(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] *= c.ArrayDecimal[i];
      return t;
    }
    return t;
  }

  public static VectorDecimal operator *(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] *= c;
    return t;
  }

  public static VectorDecimal operator /(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] /= c.ArrayDecimal[i];
      return t;
    }
    return t;
  }

  public static VectorDecimal operator /(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] /= c;
    return t;
  }

  public static VectorDecimal operator %(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] %= c.ArrayDecimal[i];
      return t;
    }
    return t;
  }

  public static VectorDecimal operator %(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] %= c;
    return t;
  }

 public static VectorDecimal operator |(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] =(char)(t.ArrayDecimal[i]) | (char)(c.ArrayDecimal[i]);
      return t;
    }
    return t;
  }

  public static VectorDecimal operator |(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] = (char)(t.ArrayDecimal[i]) | c;
    return t;
  }

  public static VectorDecimal operator ^(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] =(char)(t.ArrayDecimal[i]) ^ (char)(c.ArrayDecimal[i]);
      return t;
    }
    return t;
  }

  public static VectorDecimal operator ^(VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] = (char)(t.ArrayDecimal[i]) ^ c;
    return t;
  }
/*
  public static VectorDecimal operator >>(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] = t.ArrayDecimal[i] >> c.ArrayDecimal[i];
      return t;
    }
    return t;
    
  }

  public static VectorDecimal operator >> (VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] = (char)(t.ArrayDecimal[i]) >> c;
    return t;
  }
 /*
  public static VectorDecimal operator <<(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for (int i = 0; i < t.ArrayDecimal.Length; ++i)
        t.ArrayDecimal[i] =(char)(t.ArrayDecimal[i]) ^ (char)(c.ArrayDecimal[i]);
      return t;
    }
    return t;
  }
*/
  public static VectorDecimal operator << (VectorDecimal t, int c){
    for (int i = 0; i < t.ArrayDecimal.Length; ++i)
      t.ArrayDecimal[i] = (char)(t.ArrayDecimal[i]) << c;
    return t;
  }

  public static bool operator ==(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] == c.ArrayDecimal[i]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator !=(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] != c.ArrayDecimal[i]) return true;
      else return false;}
    }
    return true;
  }

  public static bool operator >(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] > c.ArrayDecimal[i]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator >=(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] >= c.ArrayDecimal[i]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator <(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] < c.ArrayDecimal[i]) return true;
      else return false;}
    }
    return true;
  }

  public static bool operator <=(VectorDecimal t, VectorDecimal c){
    if(t.ArrayDecimal.Length==c.ArrayDecimal.Length){
      for(int i =0;i<t.ArrayDecimal.Length;i++){
      if(t.ArrayDecimal[i] <= c.ArrayDecimal[i]) return true;
      else return false;
      }
    }
    return true;
  }


}

class DemicalMatrix{
  protected decimal [,] DCArray; 
  protected uint n,m; 
  protected int codeError;
  protected static int num_mf;
  public DemicalMatrix(){
    DCArray =new decimal[1,1];
    this.n = 1;
    this.m = 1;
    DCArray[0,0]=0;
  }
  public DemicalMatrix(uint s, uint s1){
    DCArray =new decimal[s,s1];
    this.n = s;
    this.m = s1;
    for (int i = 0; i < s; i++)
    for (int j = 0; j < s1; j++) {
      DCArray[i,j]=0;
    }
  }
  public DemicalMatrix(uint s, uint s1, int k){
    DCArray =new decimal[s,s1];
    this.n = s;
    this.m = s1;
    for (int i = 0; i < s; i++)
    for (int j = 0; j < s1; j++) {
      DCArray[i,j]=k;
    }
  }
  public void sh(){
    Console.WriteLine("Ar: ");
    for(int i =0;i<n;i++)
      for(int j =0;j<m;j++){
        Console.Write(DCArray[i,j]+" ");}
    Console.WriteLine("N: "+n);
    Console.WriteLine("M: "+m);
    Console.WriteLine("CodeError: "+codeError);
    Console.WriteLine("Num_mf: "+num_mf);
  }
  ~DemicalMatrix(){
    Console.WriteLine("Destructor");
  }
  public void arinp(){
      Console.WriteLine("Number of element: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for(int i =0;i<n;i++) 
      for(int j =0;j<m;j++){
      DCArray[i,j]=Convert.ToDecimal(Console.ReadLine());
  }}
  public void arout(){

    for (int i = 0; i < n; i++) for(int j =0;j<m;j++) {
        Console.Write(DCArray[i,j]+" ");
    }
  }
  public decimal[,] elem(decimal k){
    for(int i =0;i<n;i++) 
    for(int j =0;j<n;j++){
    DCArray [i,j] = k;
    }
    return DCArray;
  }
   public int Arlen{
    get{
      return DCArray.Length;
    }
  }  
  public int Er{
    get{
      return codeError;
    }
    set{
      codeError = value;
    }
  }  

  public decimal this[int ind]{
    get{
      if(ind<0||ind>=DCArray.Length) {
        this.codeError=1;
        return codeError;}
      return DCArray [ind,ind];
    }
    
  }

  public static DemicalMatrix operator++ (DemicalMatrix t) {
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
    t.DCArray [i,j] += 1;
    }
    return t;
  }

  public static DemicalMatrix operator-- (DemicalMatrix t) {
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
    t.DCArray [i,j] -= 1;
    }
    return t;
  }

  public static explicit operator bool(DemicalMatrix t) {
    int k=0;
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray [i,j] ==0) k++;
    }
    return ((t.n != 0)&&(t.m != 0))||(k == 0);
  }

  public static bool operator !(DemicalMatrix t) {
    return ((t.n != 0)&&(t.m!=0));
  }
 
  public static DemicalMatrix operator ~(DemicalMatrix t) {
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++) {
      t.DCArray [i,j] = (int)(t.DCArray[i,j]);
    }
    return t;
  }

  public static DemicalMatrix operator +(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] += c.DCArray[i,j];
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator +(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] += c;
    return t;
  }

  public static DemicalMatrix operator -(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] -= c.DCArray[i,j];
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator -(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] -= c;
    return t;
  }

  public static DemicalMatrix operator *(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] *= c.DCArray[i,j];
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator *(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] *= c;
    return t;
  }

  public static DemicalMatrix operator /(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] /= c.DCArray[i,j];
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator /(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] /= c;
    return t;
  }

  public static DemicalMatrix operator %(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] %= c.DCArray[i,j];
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator %(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] %= c;
    return t;
  }

  public static DemicalMatrix operator |(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] =(char)(t.DCArray[i,j]) | (char)(c.DCArray[i,j]);
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator |(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] = (char)(t.DCArray[i,j]) | c;
    return t;
  }

  public static DemicalMatrix operator ^(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] =(char)(t.DCArray[i,j]) ^ (char)(t.DCArray[i,j]);
      return t;
    }
    return t;
  }

  public static DemicalMatrix operator ^(DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] = (char)(t.DCArray[i,j]) ^ c;
    return t;
  }
/*
  public static VectorDecimal operator >>(VectorDecimal t, VectorDecimal c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] = t.DCArray[i,j] >> c.DCArray[i,j];
      return t;
    }
    return t;
    
  }

  public static VectorDecimal operator >> (VectorDecimal t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] = (char)(t.DCArray[i,j]) >> c;
    return t;
  }
 
  public static VectorDecimal operator <<(VectorDecimal t, VectorDecimal c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
        t.DCArray[i,j] = t.DCArray[i,j] << c.DCArray[i,j];
      return t;
    }
    return t;
  }
*/
  public static DemicalMatrix operator << (DemicalMatrix t, int c){
    for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++)
      t.DCArray[i,j] = (char)(t.DCArray[i,j]) << c;
    return t;
  }

  public static bool operator ==(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] == t.DCArray[i,j]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator !=(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] != t.DCArray[i,j]) return true;
      else return false;}
    }
    return true;
  }

  public static bool operator >(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] > t.DCArray[i,j]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator >=(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] >= t.DCArray[i,j]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator <(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] < t.DCArray[i,j]) return true;
      else return false;
      }
    }
    return true;
  }

  public static bool operator <=(DemicalMatrix t, DemicalMatrix c){
    if((t.n==c.n)&&(t.m==c.m)){
      for(int i =0;i<t.n;i++) for(int j =0;j<t.m;j++){
      if(t.DCArray[i,j] <= t.DCArray[i,j]) return true;
      else return false;
      }
    }
    return true;
  }


}
}