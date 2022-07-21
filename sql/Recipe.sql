DROP TABLE IF EXISTS recipe;

CREATE TABLE recipe (
    recipe_id UUID NOT NULL PRIMARY KEY DEFAULT uuid_generate_v4(),
    name_1 TEXT NOT NULL UNIQUE COLLATE case_insensitive,
    name_2 CITEXT NOT NULL UNIQUE,
    description TEXT
);

INSERT INTO recipe (name_1, name_2, description) VALUES ('meatballs', 'meatballs', 'balled up meat');
INSERT INTO recipe (name_1, name_2, description) VALUES ('red beans and rice', 'red beans and rice', 'yummy new orleans original');
INSERT INTO recipe (name_1, name_2, description) VALUES ('pasta cereal', 'pasta cereal', 'couscous and ground meat eaten with a spoon, like cereal!');