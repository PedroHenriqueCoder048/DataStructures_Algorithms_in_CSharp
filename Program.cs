using System;

namespace Solution{

	class Aplicationn{

		static void Main(string[] args){

			LinkedListStack stack = new LinkedListStack();

			stack.Push(3);

			stack.Traverse();

			stack.pop();

			stack.Traverse();

		}

	}

	class Node {

		public int value ;
		public Node next;

	}

	class LinkedListQueue{

		private Node head;
		private Node tail;
		Node current ;


		public void Enqueue(int value){

			Node newNode = new Node();

			newNode.value = value;
			newNode.next = null;

			if (head == null ){

				head = newNode;
				tail = newNode;

				Console.WriteLine("Primeiro elemento adicionado na lista");
				Console.WriteLine(value);

			}else{

				tail.next = newNode;
				tail = newNode;
				Console.WriteLine("Elemento adicionado ao final da lista");
				Console.WriteLine(value);

			}

		}

		public void Dequeue(){

			if (head == null){

				Console.WriteLine("A lista está vazia");

			}else{

				Console.WriteLine($"Valor {head.value} retirado da fila");

				head = head.next;

			}

		}

		public void Peek(){

			if (head==null){
				Console.WriteLine($"Lista está vazia");
				return;
			}

			Console.WriteLine($"primeiro valor da lista removido: {head.value}");

		}

		public void IsEmpty(){

			if (head == null){

				Console.WriteLine("A lista está vazia");
			
			}

		}

		public void Traverse(){

			if (head == null){
				Console.WriteLine("lista Vazia");
				return;
			}

			current = head;

			while(current== null){

				if (current.next != null){

					Console.WriteLine($"valor:{current.value} | próximo: {current.next.value}");
					current = current.next;

				} else{

					Console.WriteLine($"valor:{current.value} | próximo: null");
					return;

				}
			
			}

		}

		public void Search(int value){
			
			int index = 0 ;

			if (head==null){

				Console.WriteLine("Lista vazia");
				return;
			}

			current = head;

			while(current != null){

				if (current.value == value){

					 if(current.next != null)
						{
							Console.WriteLine($"Valor:{current.value} | Próximo: {current.next.value} | Index:{index}");
						}
						else
						{
							Console.WriteLine($"Valor:{current.value} | Próximo:null | Index:{index}");
						}

				}

				current = current.next;
				index +=1;

			}


		}

	}

	class LinkedListStack{

		private Node head ;
		private Node tail;

		public void Push(int value){

			Node newNode = new Node();

			if (head == null){
				
				newNode.value = value;
				newNode.next = null;

				head = newNode;
				tail = newNode;

			} else if(head == tail){

				newNode.value = value;
				newNode.next = tail;

				head = newNode;

			} else {

				newNode.value = value;
				newNode.next = head;

				head = newNode;

			}

		}

		public void pop(){

			if(head == null){

				Console.WriteLine("A lista está vazia");

			} else if(head == tail){

				head = null;
				tail = head;

			} else {

				head = head.next;

			}

		}

		public void Traverse(){

			Node current = new Node();

			current = head;

			while(current!= null){

				if (current.next != null){

					Console.WriteLine($"valor:{current.value} | próximo: {current.next.value}");
					current = current.next;

				} else{

					Console.WriteLine($"valor:{current.value} | próximo: null");
					return;

				}
			}

		}

	}

}