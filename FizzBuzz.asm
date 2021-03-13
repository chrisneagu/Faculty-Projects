.model small 
.stack 200h 
.data
 
mesaj DB 'Program Start', 0AH , 0DH, '$' 
fizz DB 'Fizz', 0AH , 0DH, '$'
buzz DB 'Buzz', 0AH , 0DH, '$'
fizzbuzz DB 'FizzBuzz', 0AH , 0DH, '$'
numar DB 0 

.code 

afisare_mesaj macro x
	lea dx,x
	mov ah,09h
	int 21h
endm

este_divizibil MACRO x
	mov ah,0
	mov al,bh
	mov cl,x
	div cl
ENDM


afisare PROC 
	mov al,bh 

	mov ch,1 
	mov cl,10 
	
impartire: 
	mov ah, 0 
	mov dx, 0 
	div cl 
	mov dl,ah 
	add dl,30h
	push dx  
	cmp al, 0 
	je afisare_din_stiva 
	mov ah, 0  
	add ch, 1 
	jmp impartire 

afisare_din_stiva: 

	POP dx 

	mov ah, 02H
	INT 21H

	SUB ch,1
	CMP ch,0
	JE iesire_afisare
	JMP afisare_din_stiva

iesire_afisare:
ret 

ENDP

citire PROC 

	MOV dl,0 
	mov cl,10
continuare:
	MOV ah, 01H
	INT 21H
	CMP al, 0DH 
	JE iesire
	CMP al,30h
	JB continuare
	CMP al,39h 
	JA continuare
	SUB al, 30H
	MOV bl,al
	MOV al,dl
	mul cl
	ADD al,bl
	MOV dl,al 
	JMP continuare
	
iesire: 
	ret
	
ENDP

Start:

mov bx,@data
mov ds,bx 

afisare_mesaj mesaj

call citire

cmp dl,0
je iesire_program


mov bl,0
mov bh,0
mov numar,dl 

bucla:
inc bh

este_divizibil 3
mov ch,ah
este_divizibil 5
cmp ch,0
je multiplucincisprezece
cmp ah,0
jne afisare_numar
afisare_mesaj buzz
jmp afara
multiplucincisprezece:
cmp ah,0 
je afisare_cincisprezece
afisare_mesaj fizz
jmp afara
afisare_cincisprezece: 
afisare_mesaj fizzbuzz
jmp afara

afisare_numar: 
call afisare
mov dl,0ah 
mov al,05h
int 21h

afara:
cmp bh,numar
je iesire_program
jmp bucla

iesire_program:
mov ah,4ch
int 21h

end Start