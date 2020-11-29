# ProjetoRevervaHotel
Projeto para disciplina de POO 2 da UVV 2020/2

O Adapter foi para ler os arquivos JSON, pois é lá onde são salvos a lista de quartos, a lista de clientes e a lista das reservas feitas.
O Command é para fazer a integração com o FAKE banco, pode ser pago com cartão de débito ou crédito (no débito sempre retorna false e no crédito sempre true).
Fiz a Factory para os gastos, pois existem vários tipos de gastos que o cliente pode ter no hotel, só implementei o serviço de telefone e alimentação.
