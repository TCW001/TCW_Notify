# TCW_Notify

<b>Olá Devs</b>, este repositório tem como objetivo <b>ajudar outros Devs</b> que queiram <b>agilizar o Desenvolvimento de seu Projeto!</b>
Só pode ser usado na <b>Unity 3D</b>.

<b>TCW Notify</b> é uma notificação com 4 tipos (Information, Success, Warning and Error). Você pode usar essa notificação para avisar o lado cliente que não tem 
X moedas suficientes, comprou o item X, que está saindo 
dos limites do mapa ou até erros que possam ocorrer!

![notify](https://user-images.githubusercontent.com/100330702/205417410-b69bfb50-b50b-4ab6-b1af-a65d8a6f2345.png)

---

<b>Tutorial | Configuração na Unity 3D</b>

> Após a importação do repositório, você pode explorar a Demo (Scene).

<b>1º Etapa</b> | 
Com a Unity aberta, na Hieraquia crie um <b>Canvas</b>.

![Create_Canvas](https://user-images.githubusercontent.com/100330702/205410569-fe3e9437-b2c9-4f2d-9d63-c3401e9657b3.png)

---

<b>2º Etapa</b> | 
Após ter criado o <b>Canvas</b>, vá em <b>TCW_Notify\Prefabs</b> e arraste o Prefab <b>Notify_Content</b> para dentro do <b>Canvas</b>. 
Posicione ele ao seu gosto!

![Prefab_Notify_Content](https://user-images.githubusercontent.com/100330702/205410956-d4eb79e3-0cd1-4f77-8e8f-726fdc285445.png)

---

<b> 3º Etapa</b> | 
Está pronto! Agora você pode criar um script e chamar a <b>Função Notify()</b>. 

A função tem 4 paramêtros.

![function](https://user-images.githubusercontent.com/100330702/205413377-5fa0f463-ec10-4efb-8e00-6ce118633a40.png)

O exemplo pode ser seguido caso o script onde chama a função esteja anexado no objeto <b>Canvas</b>.
Você pode chamar a função como o exemplo de código abaixo:

![example](https://user-images.githubusercontent.com/100330702/205413533-276e5beb-8ba6-4591-8d54-3a0f11165ed7.png)

---

> Você pode editar o código fonte (NotifyManager.cs)

> É proibido usar Comercialmente ou se Identificar como Autor do Design deste Projeto.
