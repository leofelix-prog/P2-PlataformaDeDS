CREATE EXTENSION IF NOT EXISTS btree_gist;

-- Tabela de salas
CREATE TABLE salas (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    andar INTEGER NOT NULL,
    qtddassentos INTEGER NOT NULL
);

-- Tabela de reservas
CREATE TABLE reservas (
    id SERIAL PRIMARY KEY,
    sala_id INTEGER NOT NULL,
    inicio TIMESTAMP NOT NULL,
    fim TIMESTAMP NOT NULL,
    data_cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_reservas_salas
        FOREIGN KEY (sala_id) REFERENCES salas(id),

    CONSTRAINT chk_reservas_periodo
        CHECK (fim > inicio),

    CONSTRAINT impedir_reservas_conflitantes
        EXCLUDE USING GIST (
            sala_id WITH =,
            tsrange(inicio, fim, '[)') WITH &&
        )
);