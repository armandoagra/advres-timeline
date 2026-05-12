# Como usar o projeto:

Abra a cena Scene1 em Scenes/Scene1.unity

Dê play para assistir a cutscene

# Entendendo o funcionamento

Nessa aula de Timeline + Signals, é importante entender alguns conceitos:
1. Timeline: ferramenta de criação de sequências parecido com editores de vídeo; possível manipular animações, câmeras, áudio...
2. Signals: marcadores que disparam eventos dentro de uma Timeline (bom para usar scripts ou sistemas prontos)

Explore os GameObjects e arquivos:
1. GameObject "director" e seu componente PlayableDirector
2. Arquivo Scene1Timeline.playable (clique duas vezes para abrir a janela de Timeline)
3. GameObjects Cinemachine Cameras: "entrance camera", "freezers camera", ...
4. GameObject "Tutorial Text" e seu componente Signal Receiver

## Componentes
1. Playable Director: componente colocado em um GameObject; é quem reproduz a Timeline;
2. Timeline Asset: arquivo com as tracks (faixas);
3. Track (faixa): tipo de controle, pode ser uma Animation, Cinemachine, Audio, Signal...;
4. Clip: bloco dentro de uma faixa onde alguma coisa acontece;
5. Signal Asset: um ScriptableObject que representa um evento
6. Signal Emitter: é o marcador na Signal Track
7. Signal Receiver: GameObject que escuta o sinal do marcador e executa uma resposta (UnityEvent) - você coloca esse componente no objeto que tiver outros componentes que você queira manipular;
