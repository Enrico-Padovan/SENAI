select titulo, classificacao
 from filme 
 where classificacao = 'P' or classificacao = 'R' or classificacao = 'G';
 
select titulo, classificacao
 from filme 
 where classificacao in ('P','R','G');
 
 select cidade
 from cidade
 where pais_id = 6;
 
 select cidade
 from cidade 
 where pais_id in (1, 26);
 
 select pais_id, cidade 
 from cidade
 where pais_id > 40
 order by pais_id asc;
 
 select loja_id
 from loja
 where gerente_id = 2;
 
 select *
 from idioma
 where nome = 'English';
 
 select *
 from cliente
 where ultimo_nome in ('BAILEY', 'TAYLOR');
 
 select *
 from cliente
 where primeiro_nome = 'VERONICA';
 
 select *
 from cliente
 where loja_id = 2;
 
select primeiro_nome, ultimo_nome
from atoR
where primeiro_nome in ('JENNIFER','BETTE','ELVIS','SCARLETT');

select primeiro_nome,ultimo_nome
from ator
where ator_id > 180;

select *
from aluguel
where cliente_id = 269;

select *
from aluguel
where cliente_id = 269 and funcionario_id = 1;

select f.titulo, a.primeiro_nome, a.ultimo_nome
from filme as f, ator as a, filme_ator as fa
where a.ator_id = fa.ator_id
and f.filme_id = fa.filme_id
and a.ator_id in (19,33);

select *
from pagamento
where valor > 5 and cliente_id = 12;

select * 
from pagamento
where funcionario_id <> 1;