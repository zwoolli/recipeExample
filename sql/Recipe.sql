DROP TABLE IF EXISTS recipe;

CREATE TABLE recipe (
    recipe_id UUID NOT NULL PRIMARY KEY DEFAULT uuid_generate_v4(),
    name CITEXT NOT NULL UNIQUE,
    description TEXT
);

CREATE INDEX idx_recipe_name ON recipe (name);

INSERT INTO recipe (name, description) VALUES ('meatballs', 'balled up meat');
INSERT INTO recipe (name, description) VALUES ('red beans and rice', 'yummy new orleans original');
INSERT INTO recipe (name, description) VALUES ('pasta cereal', 'couscous and ground meat eaten with a spoon, like cereal!');